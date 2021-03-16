// Administrator
// MaterialGallery
// Model
// 2021-03-15-16:41
// *Author*    : Joe, Zhou Man
// *Email*     : man.man.man.man.a@gmail.com
// *Email*     : joe_zhouman@foxmail.com
// *QQ*        : 1592020915
// *Weibo*     : @zhouman_LFC
// *Twitter*   : @zhouman_LFC
// *Website*   : www.joezhouman.com
// *Github*    : https://github.com/Joe-zhouman
// *LeetCode*  : https://leetcode-cn.com/u/joe_zm/

using System.Collections.Generic;

namespace Model {
    public class Material {
        public string ChnName { get; set; }
        public string EnName { get; set; }
        public string Component { get; set; }
        public Dictionary<string,List<Prop>> Props { get; set; }
    }
}