﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class ByteBuffer
    {
        private byte[] buffer;
        
        private int readerIndex;
        
        private int writerIndex;

        /// <summary>
        /// 读索引
        /// </summary>
        public int ReaderIndex => readerIndex;

        /// <summary>
        /// 写索引
        /// </summary>
        public int WriterIndex => writerIndex;
        
        /// <summary>
        /// Returns the number of readable bytes which is equal to
        /// writerIndex - readerIndex
        /// </summary>
        /// <returns></returns>
        public int ReadableBytes()
        {
            return writerIndex - readerIndex;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ByteBuffer Clear()
        {
            readerIndex = writerIndex = 0;
            return this;
        }
    }
}
