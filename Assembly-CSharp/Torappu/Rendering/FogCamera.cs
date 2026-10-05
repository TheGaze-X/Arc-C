using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Rendering
{
	// Token: 0x02002050 RID: 8272
	[Token(Token = "0x2002050")]
	[RequireComponent(typeof(Camera))]
	public class FogCamera : BaseSceneEffect
	{
		// Token: 0x1700182D RID: 6189
		// (get) Token: 0x0600CBE4 RID: 52196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700182D")]
		public FogProfile fogProfile
		{
			[Token(Token = "0x600CBE4")]
			[Address(RVA = "0x34D0950", Offset = "0x34CF550", VA = "0x1834D0950")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700182E RID: 6190
		// (get) Token: 0x0600CBE5 RID: 52197 RVA: 0x00049AB8 File Offset: 0x00047CB8
		[Token(Token = "0x1700182E")]
		public override BaseSceneEffect.MergeType mergeType
		{
			[Token(Token = "0x600CBE5")]
			[Address(RVA = "0x34D09B0", Offset = "0x34CF5B0", VA = "0x1834D09B0", Slot = "9")]
			get
			{
				return BaseSceneEffect.MergeType.DESTROY_COMPONENT;
			}
		}

		// Token: 0x0600CBE6 RID: 52198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBE6")]
		[Address(RVA = "0x34D0630", Offset = "0x34CF230", VA = "0x1834D0630", Slot = "5")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600CBE7 RID: 52199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBE7")]
		[Address(RVA = "0x34D0570", Offset = "0x34CF170", VA = "0x1834D0570", Slot = "7")]
		protected override void OnFinish()
		{
		}

		// Token: 0x0600CBE8 RID: 52200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBE8")]
		[Address(RVA = "0x34D08F0", Offset = "0x34CF4F0", VA = "0x1834D08F0")]
		public FogCamera()
		{
		}

		// Token: 0x0600CBE9 RID: 52201 RVA: 0x00049AD0 File Offset: 0x00047CD0
		[Token(Token = "0x600CBE9")]
		[Address(RVA = "0x34D08E0", Offset = "0x34CF4E0", VA = "0x1834D08E0")]
		private BaseSceneEffect.MergeType <>xLuaBaseProxy_get_mergeType()
		{
			return BaseSceneEffect.MergeType.DESTROY_COMPONENT;
		}

		// Token: 0x0600CBEA RID: 52202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBEA")]
		[Address(RVA = "0x34D08D0", Offset = "0x34CF4D0", VA = "0x1834D08D0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0600CBEB RID: 52203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CBEB")]
		[Address(RVA = "0x50E140", Offset = "0x50CD40", VA = "0x18050E140")]
		private void <>xLuaBaseProxy_OnFinish()
		{
		}

		// Token: 0x0400D662 RID: 54882
		[Token(Token = "0x400D662")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MeshRenderer[] _fogRenderers;

		// Token: 0x0400D663 RID: 54883
		[Token(Token = "0x400D663")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FogProfile _fogProfile;

		// Token: 0x0400D664 RID: 54884
		[Token(Token = "0x400D664")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private HighlightTileProfile _tileProfile;

		// Token: 0x0400D665 RID: 54885
		[Token(Token = "0x400D665")]
		[FieldOffset(Offset = "0x38")]
		private Camera m_camera;

		// Token: 0x0400D666 RID: 54886
		[Token(Token = "0x400D666")]
		[FieldOffset(Offset = "0x40")]
		private RenderTexture m_renderTexture;

		// Token: 0x0400D667 RID: 54887
		[Token(Token = "0x400D667")]
		[FieldOffset(Offset = "0x48")]
		private MaterialPropertyBlock m_materialPropertyBlock;

		// Token: 0x0400D668 RID: 54888
		[Token(Token = "0x400D668")]
		private const string RT_NAME_FOG = "HG FOG";

		// Token: 0x0400D669 RID: 54889
		[Token(Token = "0x400D669")]
		private const string SHADER_RT = "_DissolveTex";

		// Token: 0x0400D66A RID: 54890
		[Token(Token = "0x400D66A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_fogProfile;

		// Token: 0x0400D66B RID: 54891
		[Token(Token = "0x400D66B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_mergeType;

		// Token: 0x0400D66C RID: 54892
		[Token(Token = "0x400D66C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400D66D RID: 54893
		[Token(Token = "0x400D66D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnFinish;

		// Token: 0x0400D66E RID: 54894
		[Token(Token = "0x400D66E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
