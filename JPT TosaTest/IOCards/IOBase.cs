﻿using JPT_TosaTest.Config.HardwareManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPT_TosaTest.IOCards
{
    public abstract class IOBase
    {

        protected IOCardCfg ioCfg = null;
        /// <summary>
        /// 初始化IO卡
        /// </summary>
        /// <returns></returns>
        public abstract bool Init(IOCardCfg ioCfg);

        /// <summary>
        /// 释放资源
        /// </summary>
        /// <returns></returns>
        public abstract bool Deinit();

        /// <summary>
        /// 读取Index位的状态
        /// </summary>
        /// <param name="Index">
        /// 从0开始
        /// </param>
        /// <returns></returns>
        public abstract bool ReadIoInBit(int Index);

        /// <summary>
        /// 读取输出位的状态
        /// </summary>
        /// <param name="Index">从0开始</param>
        /// <returns></returns>
        public abstract bool ReadIoOutBit(int Index);

        /// <summary>
        /// 写输出位的状态值
        /// </summary>
        /// <param name="Index">从零开始0-15</param>
        /// <param name="value">写入的状态</param>
        /// <returns></returns>
        public abstract bool WriteIoOutBit(int Index,bool value);

        /// <summary>
        /// 读取输入字的值
        /// </summary>
        /// <param name="StartIndex">起始位，默认从0开始</param>
        /// <returns></returns>
        public abstract int ReadIoInWord(int StartIndex=0);

        /// <summary>
        /// 读取输出字的值
        /// </summary>
        /// <param name="StartIndex">其实位的，默认从0开始</param>
        /// <returns></returns>
        public abstract int ReadIoOutWord(int StartIndex=0);

        /// <summary>
        /// 一次写16位的状态值
        /// </summary>
        /// <param name="StartIndex">起始位</param>
        /// <param name="value">写入的状态字的值</param>
        /// <returns></returns>
        public abstract bool WriteIoOutWord(int StartIndex, UInt16 value);
    }
}
