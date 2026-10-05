using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020040B8 RID: 16568
	[Token(Token = "0x20040B8")]
	public class SandboxV2AdminMainModel : IHotfixable
	{
		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x06019A10 RID: 104976 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06019A11 RID: 104977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D2D")]
		public string topicId
		{
			[Token(Token = "0x6019A10")]
			[Address(RVA = "0x12771F0", Offset = "0x1275DF0", VA = "0x1812771F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6019A11")]
			[Address(RVA = "0x12773A0", Offset = "0x1275FA0", VA = "0x1812773A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x06019A12 RID: 104978 RVA: 0x0009EDD8 File Offset: 0x0009CFD8
		// (set) Token: 0x06019A13 RID: 104979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D2E")]
		public bool singleMode
		{
			[Token(Token = "0x6019A12")]
			[Address(RVA = "0x1277190", Offset = "0x1275D90", VA = "0x181277190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6019A13")]
			[Address(RVA = "0x1277330", Offset = "0x1275F30", VA = "0x181277330")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x06019A14 RID: 104980 RVA: 0x0009EDF0 File Offset: 0x0009CFF0
		// (set) Token: 0x06019A15 RID: 104981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D2F")]
		public SandboxV2AdminMainPanelType currShowType
		{
			[Token(Token = "0x6019A14")]
			[Address(RVA = "0x12770D0", Offset = "0x1275CD0", VA = "0x1812770D0")]
			[CompilerGenerated]
			get
			{
				return SandboxV2AdminMainPanelType.NONE;
			}
			[Token(Token = "0x6019A15")]
			[Address(RVA = "0x1277250", Offset = "0x1275E50", VA = "0x181277250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x06019A16 RID: 104982 RVA: 0x0009EE08 File Offset: 0x0009D008
		// (set) Token: 0x06019A17 RID: 104983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003D30")]
		public int resumeTick
		{
			[Token(Token = "0x6019A16")]
			[Address(RVA = "0x1277130", Offset = "0x1275D30", VA = "0x181277130")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6019A17")]
			[Address(RVA = "0x12772C0", Offset = "0x1275EC0", VA = "0x1812772C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06019A18 RID: 104984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A18")]
		[Address(RVA = "0x1276AB0", Offset = "0x12756B0", VA = "0x181276AB0")]
		public void Init(string topic, bool single)
		{
		}

		// Token: 0x06019A19 RID: 104985 RVA: 0x0009EE20 File Offset: 0x0009D020
		[Token(Token = "0x6019A19")]
		[Address(RVA = "0x1276D70", Offset = "0x1275970", VA = "0x181276D70")]
		public bool SetShowPanelType(SandboxV2AdminMainPanelType panelType)
		{
			return default(bool);
		}

		// Token: 0x06019A1A RID: 104986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A1A")]
		[Address(RVA = "0x1276BF0", Offset = "0x12757F0", VA = "0x181276BF0")]
		public void MarkResume()
		{
		}

		// Token: 0x06019A1B RID: 104987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A1B")]
		[Address(RVA = "0x1276E80", Offset = "0x1275A80", VA = "0x181276E80")]
		public void SetTabPanelInfo(SandboxV2AdminMainPanelType panelType, TabPanelConfig config)
		{
		}

		// Token: 0x06019A1C RID: 104988 RVA: 0x0009EE38 File Offset: 0x0009D038
		[Token(Token = "0x6019A1C")]
		[Address(RVA = "0x1276960", Offset = "0x1275560", VA = "0x181276960")]
		public TabPanelConfig GetTabPanelInfo(SandboxV2AdminMainPanelType panelType)
		{
			return default(TabPanelConfig);
		}

		// Token: 0x06019A1D RID: 104989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A1D")]
		[Address(RVA = "0x1276CF0", Offset = "0x12758F0", VA = "0x181276CF0")]
		public void RefreshPanelActiveState()
		{
		}

		// Token: 0x06019A1E RID: 104990 RVA: 0x0009EE50 File Offset: 0x0009D050
		[Token(Token = "0x6019A1E")]
		[Address(RVA = "0x12767A0", Offset = "0x12753A0", VA = "0x1812767A0")]
		public bool CheckPanelActive(SandboxV2AdminMainPanelType panelType)
		{
			return default(bool);
		}

		// Token: 0x06019A1F RID: 104991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019A1F")]
		[Address(RVA = "0x1277070", Offset = "0x1275C70", VA = "0x181277070")]
		public SandboxV2AdminMainModel()
		{
		}

		// Token: 0x0402005E RID: 131166
		[Token(Token = "0x402005E")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<SandboxV2AdminMainPanelType, TabPanelConfig> m_tabPanelInfos;

		// Token: 0x0402005F RID: 131167
		[Token(Token = "0x402005F")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<SandboxV2AdminMainPanelType, bool> m_tabPanelActive;

		// Token: 0x04020061 RID: 131169
		[Token(Token = "0x4020061")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_topicId;

		// Token: 0x04020062 RID: 131170
		[Token(Token = "0x4020062")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_topicId;

		// Token: 0x04020063 RID: 131171
		[Token(Token = "0x4020063")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_singleMode;

		// Token: 0x04020064 RID: 131172
		[Token(Token = "0x4020064")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_singleMode;

		// Token: 0x04020065 RID: 131173
		[Token(Token = "0x4020065")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_currShowType;

		// Token: 0x04020066 RID: 131174
		[Token(Token = "0x4020066")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_currShowType;

		// Token: 0x04020067 RID: 131175
		[Token(Token = "0x4020067")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_resumeTick;

		// Token: 0x04020068 RID: 131176
		[Token(Token = "0x4020068")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_resumeTick;

		// Token: 0x04020069 RID: 131177
		[Token(Token = "0x4020069")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402006A RID: 131178
		[Token(Token = "0x402006A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SetShowPanelType;

		// Token: 0x0402006B RID: 131179
		[Token(Token = "0x402006B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_MarkResume;

		// Token: 0x0402006C RID: 131180
		[Token(Token = "0x402006C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SetTabPanelInfo;

		// Token: 0x0402006D RID: 131181
		[Token(Token = "0x402006D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetTabPanelInfo;

		// Token: 0x0402006E RID: 131182
		[Token(Token = "0x402006E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshPanelActiveState;

		// Token: 0x0402006F RID: 131183
		[Token(Token = "0x402006F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CheckPanelActive;

		// Token: 0x04020070 RID: 131184
		[Token(Token = "0x4020070")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
