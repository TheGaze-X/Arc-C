using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI
{
	// Token: 0x020034C0 RID: 13504
	[Token(Token = "0x20034C0")]
	public class AdaptiveDynIllustUpdater : IHotfixable
	{
		// Token: 0x06015851 RID: 88145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015851")]
		[Address(RVA = "0xDF7BA0", Offset = "0xDF67A0", VA = "0x180DF7BA0")]
		public AdaptiveDynIllustUpdater(AdaptiveDynIllustUpdater.IContext context)
		{
		}

		// Token: 0x06015852 RID: 88146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015852")]
		[Address(RVA = "0xDF6830", Offset = "0xDF5430", VA = "0x180DF6830")]
		public void ChangeDynIllustTarget(UICharacterDynIllust illustTarget)
		{
		}

		// Token: 0x06015853 RID: 88147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015853")]
		[Address(RVA = "0xDF6970", Offset = "0xDF5570", VA = "0x180DF6970")]
		public void UpdateDynIlllusts()
		{
		}

		// Token: 0x06015854 RID: 88148 RVA: 0x0008C5F8 File Offset: 0x0008A7F8
		[Token(Token = "0x6015854")]
		[Address(RVA = "0xDF73A0", Offset = "0xDF5FA0", VA = "0x180DF73A0")]
		private DynIllustGeometryUtils.Output _CalcAdaptiveParam(DynIllustView dynIllustView, bool isCoexist)
		{
			return default(DynIllustGeometryUtils.Output);
		}

		// Token: 0x04019CA1 RID: 105633
		[Token(Token = "0x4019CA1")]
		private const float OVERFLOW_SIZE = 4f;

		// Token: 0x04019CA2 RID: 105634
		[Token(Token = "0x4019CA2")]
		private const float ZOOM_MAX_RATIO = 1.3f;

		// Token: 0x04019CA3 RID: 105635
		[Token(Token = "0x4019CA3")]
		private const float MIN_ORTHO_SIZE = 7f;

		// Token: 0x04019CA4 RID: 105636
		[Token(Token = "0x4019CA4")]
		[FieldOffset(Offset = "0x10")]
		private Vector3[] m_rawImageWorldCorners;

		// Token: 0x04019CA5 RID: 105637
		[Token(Token = "0x4019CA5")]
		[FieldOffset(Offset = "0x0")]
		private static readonly VertexHelper s_vertexHelper;

		// Token: 0x04019CA6 RID: 105638
		[Token(Token = "0x4019CA6")]
		[FieldOffset(Offset = "0x18")]
		private AdaptiveDynIllustUpdater.IContext m_context;

		// Token: 0x04019CA7 RID: 105639
		[Token(Token = "0x4019CA7")]
		[FieldOffset(Offset = "0x20")]
		private List<UICharacterDynIllust> m_dynIllustList;

		// Token: 0x04019CA8 RID: 105640
		[Token(Token = "0x4019CA8")]
		[FieldOffset(Offset = "0x28")]
		private AdaptiveDynIllustArbiter m_arbiter;

		// Token: 0x04019CA9 RID: 105641
		[Token(Token = "0x4019CA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04019CAA RID: 105642
		[Token(Token = "0x4019CAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ChangeDynIllustTarget;

		// Token: 0x04019CAB RID: 105643
		[Token(Token = "0x4019CAB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_UpdateDynIlllusts;

		// Token: 0x04019CAC RID: 105644
		[Token(Token = "0x4019CAC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CalcAdaptiveParam;

		// Token: 0x020034C1 RID: 13505
		[Token(Token = "0x20034C1")]
		public interface IContext
		{
			// Token: 0x06015856 RID: 88150
			[Token(Token = "0x6015856")]
			void FetchDynIllustList(List<UICharacterDynIllust> outputList);

			// Token: 0x06015857 RID: 88151
			[Token(Token = "0x6015857")]
			float GetIllustInstCameraSize();

			// Token: 0x06015858 RID: 88152
			[Token(Token = "0x6015858")]
			Vector3 GetRTCameraPos();

			// Token: 0x06015859 RID: 88153
			[Token(Token = "0x6015859")]
			void AdjustCamera(DynIllustGeometryUtils.Output output);
		}
	}
}
