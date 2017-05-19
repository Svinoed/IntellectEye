using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contract;
using VideoOS.Platform;
using VideoOS.Platform.Messaging;
using System.ComponentModel.Composition;

namespace Model
{
    [Export(typeof(IPTZModel))]
    public class PTZModel : IPTZModel
    {
        public ICameraModel Camera { get; set; }


        public void Down()
        {
            Move(MoveCommand.Down);            
        }

        public void DownLeft()
        {
            Move(MoveCommand.DownLeft);
        }

        public void DownRight()
        {
            Move(MoveCommand.DownRight);
        }

        public void Home()
        {
            Move(MoveCommand.Home);
        }

        public void Left()
        {
            Move(MoveCommand.Left);
        }

        public void Right()
        {
            Move(MoveCommand.Right);
        }

        public void Up()
        {
            Move(MoveCommand.Up);
        }

        public void UpLeft()
        {
            Move(MoveCommand.UpLeft); 
        }

        public void UpRight()
        {
            Move(MoveCommand.UpRight);
        }

        public void ZoomIn(float zoom)
        {
            Move(MoveCommand.ZoomIn);
        }

        public void ZoomOut(float zoom)
        {
            Move(MoveCommand.ZoomOut);
        }

        #region Move
        private void Move(MoveCommand c)
        {
            if (Camera != null)
            {
                VideoOS.Platform.Messaging.Message msg = null;
                switch (c)
                {
                    case MoveCommand.Home:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Home);
                        break;

                    case MoveCommand.Down:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Down);
                        break;

                    case MoveCommand.DownLeft:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.DownLeft);
                        break;

                    case MoveCommand.DownRight:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.DownRight);
                        break;

                    case MoveCommand.Up:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Up);
                        break;

                    case MoveCommand.UpLeft:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.UpLeft);
                        break;

                    case MoveCommand.UpRight:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.UpRight);
                        break;

                    case MoveCommand.Left:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Left);
                        break;
                                            
                    case MoveCommand.Right:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Right);
                        break;

                    case MoveCommand.ZoomIn:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.ZoomIn);
                        break;

                    case MoveCommand.ZoomOut:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.ZoomOut);
                        break;

                    default:
                        msg = new VideoOS.Platform.Messaging.Message(MessageId.Control.PTZMoveCommand, VideoOS.Platform.Messaging.PTZMoveCommandData.Home);
                        break;
                }

                EnvironmentManager.Instance.PostMessage(msg, Camera.Id);
            }
           
        }

        #endregion
    }

    enum MoveCommand
    {
        Home,
        Down,
        DownLeft,
        DownRight,
        Up,
        UpLeft,
        UpRight,
        Left,
        Right,
        ZoomIn,
        ZoomOut
    }
}
