using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FD3 RID: 28627
	[Token(Token = "0x2006FD3")]
	public class ActMultiV3PriClassModel : IHotfixable
	{
		// Token: 0x17005FFE RID: 24574
		// (get) Token: 0x06028A8E RID: 166542 RVA: 0x000D28E8 File Offset: 0x000D0AE8
		// (set) Token: 0x06028A8F RID: 166543 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005FFE")]
		public ActMultiV3IdentityType identityType
		{
			[Token(Token = "0x6028A8E")]
			[Address(RVA = "0x23EE1F0", Offset = "0x23ECDF0", VA = "0x1823EE1F0")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3IdentityType.NONE;
			}
			[Token(Token = "0x6028A8F")]
			[Address(RVA = "0x23EE250", Offset = "0x23ECE50", VA = "0x1823EE250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17005FFF RID: 24575
		// (get) Token: 0x06028A90 RID: 166544 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005FFF")]
		public ActMultiV3CharViewModel[] charArr
		{
			[Token(Token = "0x6028A90")]
			[Address(RVA = "0x23EE190", Offset = "0x23ECD90", VA = "0x1823EE190")]
			get
			{
				return null;
			}
		}

		// Token: 0x06028A91 RID: 166545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A91")]
		[Address(RVA = "0x23ED770", Offset = "0x23EC370", VA = "0x1823ED770")]
		public void GenRequestSlotList(List<RequestSquadSlot> slotList)
		{
		}

		// Token: 0x06028A92 RID: 166546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A92")]
		[Address(RVA = "0x23EDAC0", Offset = "0x23EC6C0", VA = "0x1823EDAC0")]
		public void MergeCharIdTypeDict(Dictionary<int, string> outputDict)
		{
		}

		// Token: 0x06028A93 RID: 166547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A93")]
		[Address(RVA = "0x23ED980", Offset = "0x23EC580", VA = "0x1823ED980")]
		public void LoadData(string actId, ActMultiV3Data actData, ActMultiV3MapModeType modeType, ActMultiV3IdentityType idType)
		{
		}

		// Token: 0x06028A94 RID: 166548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A94")]
		[Address(RVA = "0x23EDC90", Offset = "0x23EC890", VA = "0x1823EDC90")]
		public void ShrinkSlots()
		{
		}

		// Token: 0x06028A95 RID: 166549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A95")]
		[Address(RVA = "0x23EDD00", Offset = "0x23EC900", VA = "0x1823EDD00")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x06028A96 RID: 166550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A96")]
		[Address(RVA = "0x23EDEA0", Offset = "0x23ECAA0", VA = "0x1823EDEA0")]
		private void _InitCharList(string actId, ActMultiV3MapModeType modeType, ActMultiV3IdentityType idType)
		{
		}

		// Token: 0x06028A97 RID: 166551 RVA: 0x000D2900 File Offset: 0x000D0B00
		[Token(Token = "0x6028A97")]
		[Address(RVA = "0x23ED5C0", Offset = "0x23EC1C0", VA = "0x1823ED5C0")]
		public int CalcCharCount()
		{
			return 0;
		}

		// Token: 0x06028A98 RID: 166552 RVA: 0x000D2918 File Offset: 0x000D0B18
		[Token(Token = "0x6028A98")]
		[Address(RVA = "0x23ED620", Offset = "0x23EC220", VA = "0x1823ED620")]
		public bool CheckIfCharChanged(List<PlayerActivity.PlayerMultiV3Activity.SquadItem> playerCharList)
		{
			return default(bool);
		}

		// Token: 0x06028A99 RID: 166553 RVA: 0x000D2930 File Offset: 0x000D0B30
		[Token(Token = "0x6028A99")]
		[Address(RVA = "0x23EDDD0", Offset = "0x23EC9D0", VA = "0x1823EDDD0")]
		private int _CalcCharCount()
		{
			return 0;
		}

		// Token: 0x06028A9A RID: 166554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A9A")]
		[Address(RVA = "0x23EE130", Offset = "0x23ECD30", VA = "0x1823EE130")]
		public ActMultiV3PriClassModel()
		{
		}

		// Token: 0x04039EDE RID: 237278
		[Token(Token = "0x4039EDE")]
		[FieldOffset(Offset = "0x10")]
		private ActMultiV3CharViewModel[] m_charArr;

		// Token: 0x04039EE0 RID: 237280
		[Token(Token = "0x4039EE0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_identityType;

		// Token: 0x04039EE1 RID: 237281
		[Token(Token = "0x4039EE1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_identityType;

		// Token: 0x04039EE2 RID: 237282
		[Token(Token = "0x4039EE2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_charArr;

		// Token: 0x04039EE3 RID: 237283
		[Token(Token = "0x4039EE3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GenRequestSlotList;

		// Token: 0x04039EE4 RID: 237284
		[Token(Token = "0x4039EE4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MergeCharIdTypeDict;

		// Token: 0x04039EE5 RID: 237285
		[Token(Token = "0x4039EE5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039EE6 RID: 237286
		[Token(Token = "0x4039EE6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ShrinkSlots;

		// Token: 0x04039EE7 RID: 237287
		[Token(Token = "0x4039EE7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x04039EE8 RID: 237288
		[Token(Token = "0x4039EE8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitCharList;

		// Token: 0x04039EE9 RID: 237289
		[Token(Token = "0x4039EE9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_CalcCharCount;

		// Token: 0x04039EEA RID: 237290
		[Token(Token = "0x4039EEA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckIfCharChanged;

		// Token: 0x04039EEB RID: 237291
		[Token(Token = "0x4039EEB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CalcCharCount;

		// Token: 0x04039EEC RID: 237292
		[Token(Token = "0x4039EEC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
