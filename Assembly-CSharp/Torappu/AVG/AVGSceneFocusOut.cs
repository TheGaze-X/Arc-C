using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Torappu.AVG
{
	// Token: 0x02001EFA RID: 7930
	[Token(Token = "0x2001EFA")]
	public class AVGSceneFocusOut : AVGSceneEffectManager.EffectImplementation, PostDisplayItem.IProcessor
	{
		// Token: 0x0600C4F5 RID: 50421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F5")]
		[Address(RVA = "0x342A200", Offset = "0x3428E00", VA = "0x18342A200", Slot = "8")]
		public override void GetActiveChannels(List<string> channelList)
		{
		}

		// Token: 0x0600C4F6 RID: 50422 RVA: 0x00048348 File Offset: 0x00046548
		[Token(Token = "0x600C4F6")]
		[Address(RVA = "0x342A3D0", Offset = "0x3428FD0", VA = "0x18342A3D0", Slot = "7")]
		public override float GetAmount(string channel)
		{
			return 0f;
		}

		// Token: 0x0600C4F7 RID: 50423 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C4F7")]
		[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0", Slot = "12")]
		public override object GetConfig()
		{
			return null;
		}

		// Token: 0x0600C4F8 RID: 50424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F8")]
		[Address(RVA = "0x342A450", Offset = "0x3429050", VA = "0x18342A450", Slot = "9")]
		protected override void Render(CommandBuffer cmd, RenderTargetIdentifier src, RenderTargetIdentifier dst)
		{
		}

		// Token: 0x0600C4F9 RID: 50425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4F9")]
		[Address(RVA = "0x342B050", Offset = "0x3429C50", VA = "0x18342B050")]
		private void _SimpleColorRender(CommandBuffer cmd, RenderTargetIdentifier src, RenderTargetIdentifier dst, Material colorMat, Material alphaBlitMat)
		{
		}

		// Token: 0x0600C4FA RID: 50426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4FA")]
		[Address(RVA = "0x342AD70", Offset = "0x3429970", VA = "0x18342AD70", Slot = "6")]
		public override void SetAmount(string channel, float amount)
		{
		}

		// Token: 0x0600C4FB RID: 50427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4FB")]
		[Address(RVA = "0x342A1D0", Offset = "0x3428DD0", VA = "0x18342A1D0", Slot = "11")]
		public override void Dispose()
		{
		}

		// Token: 0x0600C4FC RID: 50428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600C4FC")]
		[Address(RVA = "0x342AEE0", Offset = "0x3429AE0", VA = "0x18342AEE0")]
		private LatchUtils.SetWhenBind<AVGAlphaGhostGraphic.BaseItem, float> _EnsureAmountSetter(string channel)
		{
			return null;
		}

		// Token: 0x0600C4FD RID: 50429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4FD")]
		[Address(RVA = "0x342B030", Offset = "0x3429C30", VA = "0x18342B030")]
		private static void _SetAmountFunc(AVGAlphaGhostGraphic.BaseItem item, float amount)
		{
		}

		// Token: 0x0600C4FE RID: 50430 RVA: 0x00048360 File Offset: 0x00046560
		[Token(Token = "0x600C4FE")]
		[Address(RVA = "0x342ADE0", Offset = "0x34299E0", VA = "0x18342ADE0", Slot = "13")]
		public bool TryRegister(PostDisplayItem item)
		{
			return default(bool);
		}

		// Token: 0x0600C4FF RID: 50431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C4FF")]
		[Address(RVA = "0x342A160", Offset = "0x3428D60", VA = "0x18342A160", Slot = "14")]
		public void BeforeItemDisposed(PostDisplayItem item)
		{
		}

		// Token: 0x0600C500 RID: 50432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600C500")]
		[Address(RVA = "0x342B210", Offset = "0x3429E10", VA = "0x18342B210")]
		public AVGSceneFocusOut()
		{
		}

		// Token: 0x0400C97E RID: 51582
		[Token(Token = "0x400C97E")]
		private const float BLUR_SIZE = 1f;

		// Token: 0x0400C97F RID: 51583
		[Token(Token = "0x400C97F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<string, LatchUtils.SetWhenBind<AVGAlphaGhostGraphic.BaseItem, float>> m_amounts;

		// Token: 0x0400C980 RID: 51584
		[Token(Token = "0x400C980")]
		[FieldOffset(Offset = "0x30")]
		private AVGSceneFocusOut.Config m_config;

		// Token: 0x0400C981 RID: 51585
		[Token(Token = "0x400C981")]
		[FieldOffset(Offset = "0x38")]
		private Material m_blurMat;

		// Token: 0x0400C982 RID: 51586
		[Token(Token = "0x400C982")]
		[FieldOffset(Offset = "0x40")]
		private Material m_colorMat;

		// Token: 0x02001EFB RID: 7931
		[Token(Token = "0x2001EFB")]
		public enum ColorMode
		{
			// Token: 0x0400C984 RID: 51588
			[Token(Token = "0x400C984")]
			NONE,
			// Token: 0x0400C985 RID: 51589
			[Token(Token = "0x400C985")]
			GRAYSCALE,
			// Token: 0x0400C986 RID: 51590
			[Token(Token = "0x400C986")]
			INVERSE
		}

		// Token: 0x02001EFC RID: 7932
		[Token(Token = "0x2001EFC")]
		public class Config
		{
			// Token: 0x0600C501 RID: 50433 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600C501")]
			[Address(RVA = "0x174F770", Offset = "0x174E370", VA = "0x18174F770")]
			public Config()
			{
			}

			// Token: 0x0400C987 RID: 51591
			[Token(Token = "0x400C987")]
			[FieldOffset(Offset = "0x10")]
			public AVGSceneFocusOut.ColorMode color;

			// Token: 0x0400C988 RID: 51592
			[Token(Token = "0x400C988")]
			[FieldOffset(Offset = "0x14")]
			public bool useBlur;
		}
	}
}
