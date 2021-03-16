// Administrator
// MaterialGallery
// Model
// 2021-03-15-16:48
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
using System.Windows.Documents;

namespace Model {
    public class Prop {
        public double TempUb { get; set; }
        public double TempLb { get; set; }
        public List<double> TempList { get; set; }
        public List<double> PropList { get; set; }
        public string Origin { get; set; }
        public string OriginUrl { get; set; }
    }
}