// Administrator
// MaterialGallery
// Model
// 2021-03-12-18:01
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

using System;
using System.Runtime.Serialization;

namespace Model {
    [Serializable]
    public class ValOutOfException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public ValOutOfException() {
        }

        public ValOutOfException(string message) : base(message) {
        }

        public ValOutOfException(string message, Exception inner) : base(message, inner) {
        }

        protected ValOutOfException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }

    [Serializable]
    public class InconsistentLengthException : Exception {
        //
        // For guidelines regarding the creation of new exception types, see
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/cpgenref/html/cpconerrorraisinghandlingguidelines.asp
        // and
        //    http://msdn.microsoft.com/library/default.asp?url=/library/en-us/dncscol/html/csharp07192001.asp
        //

        public InconsistentLengthException() {
        }

        public InconsistentLengthException(string message) : base(message) {
        }

        public InconsistentLengthException(string message, Exception inner) : base(message, inner) {
        }

        protected InconsistentLengthException(
            SerializationInfo info,
            StreamingContext context) : base(info, context) {
        }
    }
}