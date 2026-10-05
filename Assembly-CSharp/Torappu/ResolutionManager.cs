using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Setting;
using XLua;

namespace Torappu
{
	// Token: 0x02000530 RID: 1328
	[Token(Token = "0x2000530")]
	public class ResolutionManager : IHotfixable
	{
		// Token: 0x06004FB1 RID: 20401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB1")]
		[Address(RVA = "0x1AF9520", Offset = "0x1AF8120", VA = "0x181AF9520")]
		public void OnInit()
		{
		}

		// Token: 0x06004FB2 RID: 20402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB2")]
		[Address(RVA = "0x1AF93B0", Offset = "0x1AF7FB0", VA = "0x181AF93B0")]
		public void OnDispose()
		{
		}

		// Token: 0x06004FB3 RID: 20403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB3")]
		[Address(RVA = "0x1AF9A30", Offset = "0x1AF8630", VA = "0x181AF9A30")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06004FB4 RID: 20404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB4")]
		[Address(RVA = "0x1AF9DB0", Offset = "0x1AF89B0", VA = "0x181AF9DB0")]
		private void _InitResolutionSettings()
		{
		}

		// Token: 0x06004FB5 RID: 20405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB5")]
		[Address(RVA = "0x1AF9F50", Offset = "0x1AF8B50", VA = "0x181AF9F50")]
		private void _InitSetting()
		{
		}

		// Token: 0x06004FB6 RID: 20406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB6")]
		[Address(RVA = "0x1AFA0A0", Offset = "0x1AF8CA0", VA = "0x181AFA0A0")]
		private void _OnSettingChange(SettingConstVars.SettingType type)
		{
		}

		// Token: 0x06004FB7 RID: 20407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB7")]
		[Address(RVA = "0x1AFA1E0", Offset = "0x1AF8DE0", VA = "0x181AFA1E0")]
		private void _ValidateSetting(int tgtWidth, int tgtHeight, bool isFullScreen, bool isBorderless)
		{
		}

		// Token: 0x06004FB8 RID: 20408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB8")]
		[Address(RVA = "0x1AFA440", Offset = "0x1AF9040", VA = "0x181AFA440")]
		private void _ValidateWindowedResolution(int tgtWidth, int tgtHeight)
		{
		}

		// Token: 0x06004FB9 RID: 20409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FB9")]
		[Address(RVA = "0x1AF96D0", Offset = "0x1AF82D0", VA = "0x181AF96D0")]
		private void _ApplyFullScreenResolution(int tgtWidth, int tgtHeight, bool isBorderless = true)
		{
		}

		// Token: 0x06004FBA RID: 20410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBA")]
		[Address(RVA = "0x1AF9830", Offset = "0x1AF8430", VA = "0x181AF9830")]
		private void _ApplyWindowedResolution(int settingWidth, int settingHeight)
		{
		}

		// Token: 0x06004FBB RID: 20411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBB")]
		[Address(RVA = "0x1AF95A0", Offset = "0x1AF81A0", VA = "0x181AF95A0")]
		private void _ApplyFallbackWindowed()
		{
		}

		// Token: 0x06004FBC RID: 20412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004FBC")]
		[Address(RVA = "0x1AFA630", Offset = "0x1AF9230", VA = "0x181AFA630")]
		public ResolutionManager()
		{
		}

		// Token: 0x0400143F RID: 5183
		[Token(Token = "0x400143F")]
		private const int DEFAULT_FALLBACK_WIDTH = 1920;

		// Token: 0x04001440 RID: 5184
		[Token(Token = "0x4001440")]
		private const int DEFAULT_FALLBACK_HEIGHT = 1080;

		// Token: 0x04001441 RID: 5185
		[Token(Token = "0x4001441")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SettingManager.ResolutionSetting DEFAULT;

		// Token: 0x04001442 RID: 5186
		[Token(Token = "0x4001442")]
		[FieldOffset(Offset = "0x10")]
		private bool m_inited;

		// Token: 0x04001443 RID: 5187
		[Token(Token = "0x4001443")]
		[FieldOffset(Offset = "0x18")]
		private List<ResolutionSettingItemData> m_resolutionSettings;

		// Token: 0x04001444 RID: 5188
		[Token(Token = "0x4001444")]
		[FieldOffset(Offset = "0x20")]
		private SettingManager.ResolutionSetting m_setting;

		// Token: 0x04001445 RID: 5189
		[Token(Token = "0x4001445")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04001446 RID: 5190
		[Token(Token = "0x4001446")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDispose;

		// Token: 0x04001447 RID: 5191
		[Token(Token = "0x4001447")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04001448 RID: 5192
		[Token(Token = "0x4001448")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitResolutionSettings;

		// Token: 0x04001449 RID: 5193
		[Token(Token = "0x4001449")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitSetting;

		// Token: 0x0400144A RID: 5194
		[Token(Token = "0x400144A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnSettingChange;

		// Token: 0x0400144B RID: 5195
		[Token(Token = "0x400144B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ValidateSetting;

		// Token: 0x0400144C RID: 5196
		[Token(Token = "0x400144C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ValidateWindowedResolution;

		// Token: 0x0400144D RID: 5197
		[Token(Token = "0x400144D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ApplyFullScreenResolution;

		// Token: 0x0400144E RID: 5198
		[Token(Token = "0x400144E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ApplyWindowedResolution;

		// Token: 0x0400144F RID: 5199
		[Token(Token = "0x400144F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ApplyFallbackWindowed;

		// Token: 0x04001450 RID: 5200
		[Token(Token = "0x4001450")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
