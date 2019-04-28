using System.Collections.Generic;
using Robot.Comm;

namespace Robot.IService
{
    public interface IRobotsManagerService
    {
        Dictionary<int, RobotSession> GetSessionTable();
        /// <summary>
        /// 服务器启动
        /// </summary>
        /// <returns>启动是否成功,true:成功,false:失败</returns>
        bool StartServer();
        /// <summary>
        /// 服务器关闭
        /// </summary>
        void StopServer();
        /// <summary>
        /// 根据小车名称启动小车
        /// </summary>
        /// <param name="cartName">小车名称</param>
        /// <returns></returns>
        bool CartStartByCartName(string cartName);
        /// <summary>
        /// 根据小车名称停止小车
        /// </summary>
        /// <param name="cartName">小车名称</param>
        /// <returns></returns>
        bool CartStopByCartName(string cartName);
        /// <summary>
        /// 自动执行满足条件的任务
        /// </summary>
        void AutoExceTaskOrder();
        /// <summary>
        /// 任务控制指令（暂停，恢复，停止任务)
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="cartName"></param>
        /// <returns></returns>
        bool CtrlTaskByOrderId(int orderId, string cartName, int ctrlType);
    }


}
