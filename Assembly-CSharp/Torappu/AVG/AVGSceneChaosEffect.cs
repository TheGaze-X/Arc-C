using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Torappu.AVG
{
	// Token: 0x02001EF1 RID: 7921
	[Token(Token = "0x2001EF1")]
	public class AVGSceneChaosEffect : AVGSceneEffectManager.EffectImplementation
	{
		// Token: 0x0600C49E RID: 50334 RVA: 0x00048138 File Offset: 0x00046338
		[Token(Token = "0x600C49E")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "10")]
		public override bool RequiresScissor()
		{
			return default(bool);
		}

		// Token: 0x0600C49F RID: 50335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C49F")]
		[Address(RVA = "0x34242A0", Offset = "0x3422EA0", VA = "0x1834242A0", Slot = "8")]
		public override void GetActiveChannels(List<string> channelList)
		{
		}

		// Token: 0x0600C4A0 RID: 50336 RVA: 0x00048150 File Offset: 0x00046350
		[Token(Token = "0x600C4A0")]
		[Address(RVA = "0x3424350", Offset = "0x3422F50", VA = "0x183424350", Slot = "7")]
		public override float GetAmount(string channel)
		{
			return 0f;
		}

		// Token: 0x0600C4A1 RID: 50337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A1")]
		[Address(RVA = "0x3424B30", Offset = "0x3423730", VA = "0x183424B30", Slot = "6")]
		public override void SetAmount(string channel, float amount)
		{
		}

		// Token: 0x0600C4A2 RID: 50338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A2")]
		[Address(RVA = "0x34247B0", Offset = "0x34233B0", VA = "0x1834247B0", Slot = "9")]
		protected override void Render(CommandBuffer cmd, RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
		}

		// Token: 0x0600C4A3 RID: 50339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A3")]
		[Address(RVA = "0x34243C0", Offset = "0x3422FC0", VA = "0x1834243C0")]
		private void InitializeMaterials()
		{
		}

		// Token: 0x0600C4A4 RID: 50340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A4")]
		[Address(RVA = "0x3424B50", Offset = "0x3423750", VA = "0x183424B50")]
		private void _ApplyAmountsToMaterial(float amount)
		{
		}

		// Token: 0x0600C4A5 RID: 50341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C4A5")]
		[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850", Slot = "12")]
		public override object GetConfig()
		{
			return null;
		}

		// Token: 0x0600C4A6 RID: 50342 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C4A6")]
		[Address(RVA = "0x3424D80", Offset = "0x3423980", VA = "0x183424D80")]
		private AVGChaosMaterialSettings _LoadChaosMaterialParam(string settingName)
		{
			return null;
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4A7")]
		[Address(RVA = "0x3424E40", Offset = "0x3423A40", VA = "0x183424E40")]
		public AVGSceneChaosEffect()
		{
		}

		// Token: 0x0400C911 RID: 51473
		[Token(Token = "0x400C911")]
		[FieldOffset(Offset = "0x28")]
		private Material m_chaosMat;

		// Token: 0x0400C912 RID: 51474
		[Token(Token = "0x400C912")]
		[FieldOffset(Offset = "0x30")]
		private Material m_blurMat;

		// Token: 0x0400C913 RID: 51475
		[Token(Token = "0x400C913")]
		[FieldOffset(Offset = "0x38")]
		private AVGSceneChaosEffect.Config m_config;

		// Token: 0x0400C914 RID: 51476
		[Token(Token = "0x400C914")]
		[FieldOffset(Offset = "0x40")]
		private AVGChaosMaterialSettings m_fromSetting;

		// Token: 0x0400C915 RID: 51477
		[Token(Token = "0x400C915")]
		[FieldOffset(Offset = "0x48")]
		private AVGChaosMaterialSettings m_toSetting;

		// Token: 0x0400C916 RID: 51478
		[Token(Token = "0x400C916")]
		[FieldOffset(Offset = "0x50")]
		private AVGChaosMatParam m_fromParam;

		// Token: 0x0400C917 RID: 51479
		[Token(Token = "0x400C917")]
		[FieldOffset(Offset = "0x8C")]
		private AVGChaosMatParam m_toParam;

		// Token: 0x0400C918 RID: 51480
		[Token(Token = "0x400C918")]
		[FieldOffset(Offset = "0xC8")]
		private AVGChaosMatParam m_currentParam;

		// Token: 0x0400C919 RID: 51481
		[Token(Token = "0x400C919")]
		[FieldOffset(Offset = "0x104")]
		private float m_pendingChaosAmount;

		// Token: 0x0400C91A RID: 51482
		[Token(Token = "0x400C91A")]
		[FieldOffset(Offset = "0x108")]
		private float m_appliedChaosAmount;

		// Token: 0x0400C91B RID: 51483
		[Token(Token = "0x400C91B")]
		[FieldOffset(Offset = "0x10C")]
		private bool m_isMaterialInitialized;

		// Token: 0x02001EF2 RID: 7922
		[Token(Token = "0x2001EF2")]
		public class Config
		{
			// Token: 0x0600C4A8 RID: 50344 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C4A8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Config()
			{
			}

			// Token: 0x0400C91C RID: 51484
			[Token(Token = "0x400C91C")]
			[FieldOffset(Offset = "0x10")]
			public string fromSetting;

			// Token: 0x0400C91D RID: 51485
			[Token(Token = "0x400C91D")]
			[FieldOffset(Offset = "0x18")]
			public string toSetting;
		}
	}
}
