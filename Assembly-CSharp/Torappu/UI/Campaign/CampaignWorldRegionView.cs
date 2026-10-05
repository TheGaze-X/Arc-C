using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060FC RID: 24828
	[Token(Token = "0x20060FC")]
	public class CampaignWorldRegionView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023E22 RID: 146978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E22")]
		[Address(RVA = "0x1E8DEF0", Offset = "0x1E8CAF0", VA = "0x181E8DEF0")]
		public void Render(CampaignWorldRegionViewModel viewModel)
		{
		}

		// Token: 0x06023E23 RID: 146979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E23")]
		[Address(RVA = "0x1E8DCF0", Offset = "0x1E8C8F0", VA = "0x181E8DCF0")]
		public void PlayFogDisappear()
		{
		}

		// Token: 0x06023E24 RID: 146980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E24")]
		[Address(RVA = "0x1E8DFE0", Offset = "0x1E8CBE0", VA = "0x181E8DFE0")]
		public void StopEffect()
		{
		}

		// Token: 0x06023E25 RID: 146981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E25")]
		[Address(RVA = "0x1E8E070", Offset = "0x1E8CC70", VA = "0x181E8E070")]
		private void _ApplyHolderConfig()
		{
		}

		// Token: 0x06023E26 RID: 146982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E26")]
		[Address(RVA = "0x1E8DC90", Offset = "0x1E8C890", VA = "0x181E8DC90")]
		public void Awake()
		{
		}

		// Token: 0x06023E27 RID: 146983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E27")]
		[Address(RVA = "0x1E8E930", Offset = "0x1E8D530", VA = "0x181E8E930")]
		public CampaignWorldRegionView()
		{
		}

		// Token: 0x04031C6B RID: 203883
		[Token(Token = "0x4031C6B")]
		private const string FOG_MATERIAL_COLOR_PROPERTY = "_TintColor";

		// Token: 0x04031C6C RID: 203884
		[Token(Token = "0x4031C6C")]
		private const int PIXEL_PER_UNIT = 100;

		// Token: 0x04031C6D RID: 203885
		[Token(Token = "0x4031C6D")]
		private const float FADE_DURATION = 1f;

		// Token: 0x04031C6E RID: 203886
		[Token(Token = "0x4031C6E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ParticleSystem _constantFog;

		// Token: 0x04031C6F RID: 203887
		[Token(Token = "0x4031C6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ParticleSystem _disappearFog;

		// Token: 0x04031C70 RID: 203888
		[Token(Token = "0x4031C70")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031C71 RID: 203889
		[Token(Token = "0x4031C71")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlayFogDisappear;

		// Token: 0x04031C72 RID: 203890
		[Token(Token = "0x4031C72")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_StopEffect;

		// Token: 0x04031C73 RID: 203891
		[Token(Token = "0x4031C73")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyHolderConfig;

		// Token: 0x04031C74 RID: 203892
		[Token(Token = "0x4031C74")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04031C75 RID: 203893
		[Token(Token = "0x4031C75")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
