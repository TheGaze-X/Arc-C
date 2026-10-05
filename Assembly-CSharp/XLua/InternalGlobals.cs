using System;
using System.Collections.Generic;
using System.Reflection;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using Il2CppDummyDll;
using Torappu;
using UnityEngine;
using UnityEngine.UI;
using XLua.LuaDLL;

namespace XLua
{
	// Token: 0x0200025F RID: 607
	[Token(Token = "0x200025F")]
	internal class InternalGlobals
	{
		// Token: 0x06003565 RID: 13669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003565")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public InternalGlobals()
		{
		}

		// Token: 0x04000CEA RID: 3306
		[Token(Token = "0x4000CEA")]
		[FieldOffset(Offset = "0x0")]
		internal static InternalGlobals.TryArrayGet genTryArrayGetPtr;

		// Token: 0x04000CEB RID: 3307
		[Token(Token = "0x4000CEB")]
		[FieldOffset(Offset = "0x8")]
		internal static InternalGlobals.TryArraySet genTryArraySetPtr;

		// Token: 0x04000CEC RID: 3308
		[Token(Token = "0x4000CEC")]
		[FieldOffset(Offset = "0x10")]
		internal static ObjectTranslatorPool objectTranslatorPool;

		// Token: 0x04000CED RID: 3309
		[Token(Token = "0x4000CED")]
		[FieldOffset(Offset = "0x18")]
		internal static int LUA_REGISTRYINDEX;

		// Token: 0x04000CEE RID: 3310
		[Token(Token = "0x4000CEE")]
		[FieldOffset(Offset = "0x20")]
		internal static Dictionary<string, string> supportOp;

		// Token: 0x04000CEF RID: 3311
		[Token(Token = "0x4000CEF")]
		[FieldOffset(Offset = "0x28")]
		internal static Dictionary<Type, IEnumerable<MethodInfo>> extensionMethodMap;

		// Token: 0x04000CF0 RID: 3312
		[Token(Token = "0x4000CF0")]
		[FieldOffset(Offset = "0x30")]
		internal static lua_CSFunction LazyReflectionWrap;

		// Token: 0x02000260 RID: 608
		// (Invoke) Token: 0x06003567 RID: 13671
		[Token(Token = "0x2000260")]
		private delegate bool __GEN_DELEGATE0(UnityEngine.Object o);

		// Token: 0x02000261 RID: 609
		// (Invoke) Token: 0x0600356B RID: 13675
		[Token(Token = "0x2000261")]
		private delegate bool __GEN_DELEGATE1(PlayerBuildingChar playerChar);

		// Token: 0x02000262 RID: 610
		// (Invoke) Token: 0x0600356F RID: 13679
		[Token(Token = "0x2000262")]
		private delegate float __GEN_DELEGATE2(float value, float from1, float to1, float from2, float to2);

		// Token: 0x02000263 RID: 611
		// (Invoke) Token: 0x06003573 RID: 13683
		[Token(Token = "0x2000263")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE3(TweenerCore<Color, Color, ColorOptions> t, float fromAlphaValue, bool setImmediately, bool isRelative);

		// Token: 0x02000264 RID: 612
		// (Invoke) Token: 0x06003577 RID: 13687
		[Token(Token = "0x2000264")]
		private delegate TweenerCore<Vector2, Vector2, CircleOptions> __GEN_DELEGATE4(TweenerCore<Vector2, Vector2, CircleOptions> t, float fromValueDegrees, bool setImmediately, bool isRelative);

		// Token: 0x02000265 RID: 613
		// (Invoke) Token: 0x0600357B RID: 13691
		[Token(Token = "0x2000265")]
		private delegate Tweener __GEN_DELEGATE5(TweenerCore<float, float, FloatOptions> t, bool snapping);

		// Token: 0x02000266 RID: 614
		// (Invoke) Token: 0x0600357F RID: 13695
		[Token(Token = "0x2000266")]
		private delegate Tweener __GEN_DELEGATE6(TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping);

		// Token: 0x02000267 RID: 615
		// (Invoke) Token: 0x06003583 RID: 13699
		[Token(Token = "0x2000267")]
		private delegate Tweener __GEN_DELEGATE7(TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x02000268 RID: 616
		// (Invoke) Token: 0x06003587 RID: 13703
		[Token(Token = "0x2000268")]
		private delegate Tweener __GEN_DELEGATE8(TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping);

		// Token: 0x02000269 RID: 617
		// (Invoke) Token: 0x0600358B RID: 13707
		[Token(Token = "0x2000269")]
		private delegate Tweener __GEN_DELEGATE9(TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x0200026A RID: 618
		// (Invoke) Token: 0x0600358F RID: 13711
		[Token(Token = "0x200026A")]
		private delegate Tweener __GEN_DELEGATE10(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route);

		// Token: 0x0200026B RID: 619
		// (Invoke) Token: 0x06003593 RID: 13715
		[Token(Token = "0x200026B")]
		private delegate Tweener __GEN_DELEGATE11(TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly);

		// Token: 0x0200026C RID: 620
		// (Invoke) Token: 0x06003597 RID: 13719
		[Token(Token = "0x200026C")]
		private delegate Tweener __GEN_DELEGATE12(TweenerCore<Rect, Rect, RectOptions> t, bool snapping);

		// Token: 0x0200026D RID: 621
		// (Invoke) Token: 0x0600359B RID: 13723
		[Token(Token = "0x200026D")]
		private delegate Tweener __GEN_DELEGATE13(TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode, string scrambleChars);

		// Token: 0x0200026E RID: 622
		// (Invoke) Token: 0x0600359F RID: 13727
		[Token(Token = "0x200026E")]
		private delegate Tweener __GEN_DELEGATE14(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping);

		// Token: 0x0200026F RID: 623
		// (Invoke) Token: 0x060035A3 RID: 13731
		[Token(Token = "0x200026F")]
		private delegate Tweener __GEN_DELEGATE15(TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping);

		// Token: 0x02000270 RID: 624
		// (Invoke) Token: 0x060035A7 RID: 13735
		[Token(Token = "0x2000270")]
		private delegate Tweener __GEN_DELEGATE16(TweenerCore<Vector2, Vector2, CircleOptions> t, float endValueDegrees, bool relativeCenter, bool snapping);

		// Token: 0x02000271 RID: 625
		// (Invoke) Token: 0x060035AB RID: 13739
		[Token(Token = "0x2000271")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE17(TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation);

		// Token: 0x02000272 RID: 626
		// (Invoke) Token: 0x060035AF RID: 13743
		[Token(Token = "0x2000272")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE18(TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition, AxisConstraint lockRotation);

		// Token: 0x02000273 RID: 627
		// (Invoke) Token: 0x060035B3 RID: 13747
		[Token(Token = "0x2000273")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE19(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection, Vector3? up);

		// Token: 0x02000274 RID: 628
		// (Invoke) Token: 0x060035B7 RID: 13751
		[Token(Token = "0x2000274")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE20(TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, bool stableZRotation);

		// Token: 0x02000275 RID: 629
		// (Invoke) Token: 0x060035BB RID: 13755
		[Token(Token = "0x2000275")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE21(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection, Vector3? up);

		// Token: 0x02000276 RID: 630
		// (Invoke) Token: 0x060035BF RID: 13759
		[Token(Token = "0x2000276")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE22(TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, bool stableZRotation);

		// Token: 0x02000277 RID: 631
		// (Invoke) Token: 0x060035C3 RID: 13763
		[Token(Token = "0x2000277")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE23(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection, Vector3? up);

		// Token: 0x02000278 RID: 632
		// (Invoke) Token: 0x060035C7 RID: 13767
		[Token(Token = "0x2000278")]
		private delegate TweenerCore<Vector3, Path, PathOptions> __GEN_DELEGATE24(TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, bool stableZRotation);

		// Token: 0x02000279 RID: 633
		// (Invoke) Token: 0x060035CB RID: 13771
		[Token(Token = "0x2000279")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE25(Camera target, float endValue, float duration);

		// Token: 0x0200027A RID: 634
		// (Invoke) Token: 0x060035CF RID: 13775
		[Token(Token = "0x200027A")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE26(Camera target, Color endValue, float duration);

		// Token: 0x0200027B RID: 635
		// (Invoke) Token: 0x060035D3 RID: 13779
		[Token(Token = "0x200027B")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE27(Camera target, float endValue, float duration);

		// Token: 0x0200027C RID: 636
		// (Invoke) Token: 0x060035D7 RID: 13783
		[Token(Token = "0x200027C")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE28(Camera target, float endValue, float duration);

		// Token: 0x0200027D RID: 637
		// (Invoke) Token: 0x060035DB RID: 13787
		[Token(Token = "0x200027D")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE29(Camera target, float endValue, float duration);

		// Token: 0x0200027E RID: 638
		// (Invoke) Token: 0x060035DF RID: 13791
		[Token(Token = "0x200027E")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE30(Camera target, float endValue, float duration);

		// Token: 0x0200027F RID: 639
		// (Invoke) Token: 0x060035E3 RID: 13795
		[Token(Token = "0x200027F")]
		private delegate TweenerCore<Rect, Rect, RectOptions> __GEN_DELEGATE31(Camera target, Rect endValue, float duration);

		// Token: 0x02000280 RID: 640
		// (Invoke) Token: 0x060035E7 RID: 13799
		[Token(Token = "0x2000280")]
		private delegate TweenerCore<Rect, Rect, RectOptions> __GEN_DELEGATE32(Camera target, Rect endValue, float duration);

		// Token: 0x02000281 RID: 641
		// (Invoke) Token: 0x060035EB RID: 13803
		[Token(Token = "0x2000281")]
		private delegate Tweener __GEN_DELEGATE33(Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut, ShakeRandomnessMode randomnessMode);

		// Token: 0x02000282 RID: 642
		// (Invoke) Token: 0x060035EF RID: 13807
		[Token(Token = "0x2000282")]
		private delegate Tweener __GEN_DELEGATE34(Camera target, float duration, Vector3 strength, int vibrato, float randomness, bool fadeOut, ShakeRandomnessMode randomnessMode);

		// Token: 0x02000283 RID: 643
		// (Invoke) Token: 0x060035F3 RID: 13811
		[Token(Token = "0x2000283")]
		private delegate Tweener __GEN_DELEGATE35(Camera target, float duration, float strength, int vibrato, float randomness, bool fadeOut, ShakeRandomnessMode randomnessMode);

		// Token: 0x02000284 RID: 644
		// (Invoke) Token: 0x060035F7 RID: 13815
		[Token(Token = "0x2000284")]
		private delegate Tweener __GEN_DELEGATE36(Camera target, float duration, Vector3 strength, int vibrato, float randomness, bool fadeOut, ShakeRandomnessMode randomnessMode);

		// Token: 0x02000285 RID: 645
		// (Invoke) Token: 0x060035FB RID: 13819
		[Token(Token = "0x2000285")]
		private delegate Tweener __GEN_DELEGATE37(LineRenderer target, Color2 startValue, Color2 endValue, float duration);

		// Token: 0x02000286 RID: 646
		// (Invoke) Token: 0x060035FF RID: 13823
		[Token(Token = "0x2000286")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE38(Material target, Color endValue, float duration);

		// Token: 0x02000287 RID: 647
		// (Invoke) Token: 0x06003603 RID: 13827
		[Token(Token = "0x2000287")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE39(Material target, Color endValue, string property, float duration);

		// Token: 0x02000288 RID: 648
		// (Invoke) Token: 0x06003607 RID: 13831
		[Token(Token = "0x2000288")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE40(Material target, Color endValue, int propertyID, float duration);

		// Token: 0x02000289 RID: 649
		// (Invoke) Token: 0x0600360B RID: 13835
		[Token(Token = "0x2000289")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE41(Material target, float endValue, float duration);

		// Token: 0x0200028A RID: 650
		// (Invoke) Token: 0x0600360F RID: 13839
		[Token(Token = "0x200028A")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE42(Material target, float endValue, string property, float duration);

		// Token: 0x0200028B RID: 651
		// (Invoke) Token: 0x06003613 RID: 13843
		[Token(Token = "0x200028B")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE43(Material target, float endValue, int propertyID, float duration);

		// Token: 0x0200028C RID: 652
		// (Invoke) Token: 0x06003617 RID: 13847
		[Token(Token = "0x200028C")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE44(Material target, float endValue, string property, float duration);

		// Token: 0x0200028D RID: 653
		// (Invoke) Token: 0x0600361B RID: 13851
		[Token(Token = "0x200028D")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE45(Material target, float endValue, int propertyID, float duration);

		// Token: 0x0200028E RID: 654
		// (Invoke) Token: 0x0600361F RID: 13855
		[Token(Token = "0x200028E")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE46(Material target, Vector2 endValue, float duration);

		// Token: 0x0200028F RID: 655
		// (Invoke) Token: 0x06003623 RID: 13859
		[Token(Token = "0x200028F")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE47(Material target, Vector2 endValue, string property, float duration);

		// Token: 0x02000290 RID: 656
		// (Invoke) Token: 0x06003627 RID: 13863
		[Token(Token = "0x2000290")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE48(Material target, Vector2 endValue, float duration);

		// Token: 0x02000291 RID: 657
		// (Invoke) Token: 0x0600362B RID: 13867
		[Token(Token = "0x2000291")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE49(Material target, Vector2 endValue, string property, float duration);

		// Token: 0x02000292 RID: 658
		// (Invoke) Token: 0x0600362F RID: 13871
		[Token(Token = "0x2000292")]
		private delegate TweenerCore<Vector4, Vector4, VectorOptions> __GEN_DELEGATE50(Material target, Vector4 endValue, string property, float duration);

		// Token: 0x02000293 RID: 659
		// (Invoke) Token: 0x06003633 RID: 13875
		[Token(Token = "0x2000293")]
		private delegate TweenerCore<Vector4, Vector4, VectorOptions> __GEN_DELEGATE51(Material target, Vector4 endValue, int propertyID, float duration);

		// Token: 0x02000294 RID: 660
		// (Invoke) Token: 0x06003637 RID: 13879
		[Token(Token = "0x2000294")]
		private delegate Tweener __GEN_DELEGATE52(TrailRenderer target, float toStartWidth, float toEndWidth, float duration);

		// Token: 0x02000295 RID: 661
		// (Invoke) Token: 0x0600363B RID: 13883
		[Token(Token = "0x2000295")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE53(TrailRenderer target, float endValue, float duration);

		// Token: 0x02000296 RID: 662
		// (Invoke) Token: 0x0600363F RID: 13887
		[Token(Token = "0x2000296")]
		private delegate Tweener __GEN_DELEGATE54(Material target, Color endValue, float duration);

		// Token: 0x02000297 RID: 663
		// (Invoke) Token: 0x06003643 RID: 13891
		[Token(Token = "0x2000297")]
		private delegate Tweener __GEN_DELEGATE55(Material target, Color endValue, string property, float duration);

		// Token: 0x02000298 RID: 664
		// (Invoke) Token: 0x06003647 RID: 13895
		[Token(Token = "0x2000298")]
		private delegate Tweener __GEN_DELEGATE56(Material target, Color endValue, int propertyID, float duration);

		// Token: 0x02000299 RID: 665
		// (Invoke) Token: 0x0600364B RID: 13899
		[Token(Token = "0x2000299")]
		private delegate int __GEN_DELEGATE57(Material target, bool withCallbacks);

		// Token: 0x0200029A RID: 666
		// (Invoke) Token: 0x0600364F RID: 13903
		[Token(Token = "0x200029A")]
		private delegate int __GEN_DELEGATE58(Material target, bool complete);

		// Token: 0x0200029B RID: 667
		// (Invoke) Token: 0x06003653 RID: 13907
		[Token(Token = "0x200029B")]
		private delegate int __GEN_DELEGATE59(Material target);

		// Token: 0x0200029C RID: 668
		// (Invoke) Token: 0x06003657 RID: 13911
		[Token(Token = "0x200029C")]
		private delegate int __GEN_DELEGATE60(Material target, float to, bool andPlay);

		// Token: 0x0200029D RID: 669
		// (Invoke) Token: 0x0600365B RID: 13915
		[Token(Token = "0x200029D")]
		private delegate int __GEN_DELEGATE61(Material target);

		// Token: 0x0200029E RID: 670
		// (Invoke) Token: 0x0600365F RID: 13919
		[Token(Token = "0x200029E")]
		private delegate int __GEN_DELEGATE62(Material target);

		// Token: 0x0200029F RID: 671
		// (Invoke) Token: 0x06003663 RID: 13923
		[Token(Token = "0x200029F")]
		private delegate int __GEN_DELEGATE63(Material target);

		// Token: 0x020002A0 RID: 672
		// (Invoke) Token: 0x06003667 RID: 13927
		[Token(Token = "0x20002A0")]
		private delegate int __GEN_DELEGATE64(Material target);

		// Token: 0x020002A1 RID: 673
		// (Invoke) Token: 0x0600366B RID: 13931
		[Token(Token = "0x20002A1")]
		private delegate int __GEN_DELEGATE65(Material target, bool includeDelay);

		// Token: 0x020002A2 RID: 674
		// (Invoke) Token: 0x0600366F RID: 13935
		[Token(Token = "0x20002A2")]
		private delegate int __GEN_DELEGATE66(Material target, bool includeDelay);

		// Token: 0x020002A3 RID: 675
		// (Invoke) Token: 0x06003673 RID: 13939
		[Token(Token = "0x20002A3")]
		private delegate int __GEN_DELEGATE67(Material target);

		// Token: 0x020002A4 RID: 676
		// (Invoke) Token: 0x06003677 RID: 13943
		[Token(Token = "0x20002A4")]
		private delegate int __GEN_DELEGATE68(Material target);

		// Token: 0x020002A5 RID: 677
		// (Invoke) Token: 0x0600367B RID: 13947
		[Token(Token = "0x20002A5")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE69(Graphic target, Color endValue, float duration);

		// Token: 0x020002A6 RID: 678
		// (Invoke) Token: 0x0600367F RID: 13951
		[Token(Token = "0x20002A6")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE70(Graphic target, float endValue, float duration);

		// Token: 0x020002A7 RID: 679
		// (Invoke) Token: 0x06003683 RID: 13955
		[Token(Token = "0x20002A7")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE71(LayoutElement target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x020002A8 RID: 680
		// (Invoke) Token: 0x06003687 RID: 13959
		[Token(Token = "0x20002A8")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE72(LayoutElement target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x020002A9 RID: 681
		// (Invoke) Token: 0x0600368B RID: 13963
		[Token(Token = "0x20002A9")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE73(LayoutElement target, Vector2 endValue, float duration, bool snapping);

		// Token: 0x020002AA RID: 682
		// (Invoke) Token: 0x0600368F RID: 13967
		[Token(Token = "0x20002AA")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE74(Outline target, Color endValue, float duration);

		// Token: 0x020002AB RID: 683
		// (Invoke) Token: 0x06003693 RID: 13971
		[Token(Token = "0x20002AB")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE75(Outline target, float endValue, float duration);

		// Token: 0x020002AC RID: 684
		// (Invoke) Token: 0x06003697 RID: 13975
		[Token(Token = "0x20002AC")]
		private delegate TweenerCore<Vector2, Vector2, VectorOptions> __GEN_DELEGATE76(Outline target, Vector2 endValue, float duration);

		// Token: 0x020002AD RID: 685
		// (Invoke) Token: 0x0600369B RID: 13979
		[Token(Token = "0x20002AD")]
		private delegate TweenerCore<float, float, FloatOptions> __GEN_DELEGATE77(Slider target, float endValue, float duration, bool snapping);

		// Token: 0x020002AE RID: 686
		// (Invoke) Token: 0x0600369F RID: 13983
		[Token(Token = "0x20002AE")]
		private delegate Tweener __GEN_DELEGATE78(Graphic target, Color endValue, float duration);

		// Token: 0x020002AF RID: 687
		// (Invoke) Token: 0x060036A3 RID: 13987
		[Token(Token = "0x20002AF")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE79(SpriteRenderer target, Color endValue, float duration);

		// Token: 0x020002B0 RID: 688
		// (Invoke) Token: 0x060036A7 RID: 13991
		[Token(Token = "0x20002B0")]
		private delegate TweenerCore<Color, Color, ColorOptions> __GEN_DELEGATE80(SpriteRenderer target, float endValue, float duration);

		// Token: 0x020002B1 RID: 689
		// (Invoke) Token: 0x060036AB RID: 13995
		[Token(Token = "0x20002B1")]
		private delegate Sequence __GEN_DELEGATE81(SpriteRenderer target, Gradient gradient, float duration);

		// Token: 0x020002B2 RID: 690
		// (Invoke) Token: 0x060036AF RID: 13999
		[Token(Token = "0x20002B2")]
		private delegate Tweener __GEN_DELEGATE82(SpriteRenderer target, Color endValue, float duration);

		// Token: 0x020002B3 RID: 691
		// (Invoke) Token: 0x060036B3 RID: 14003
		[Token(Token = "0x20002B3")]
		internal delegate bool TryArrayGet(Type type, IntPtr L, ObjectTranslator translator, object obj, int index);

		// Token: 0x020002B4 RID: 692
		// (Invoke) Token: 0x060036B7 RID: 14007
		[Token(Token = "0x20002B4")]
		internal delegate bool TryArraySet(Type type, IntPtr L, ObjectTranslator translator, object obj, int array_idx, int obj_idx);
	}
}
