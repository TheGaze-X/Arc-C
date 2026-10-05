using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006FD4 RID: 28628
	[Token(Token = "0x2006FD4")]
	public class ActMultiV3CharViewModel : CommonCharCardViewModel, ISquadMemberCompInfo, IHotfixable
	{
		// Token: 0x17006000 RID: 24576
		// (get) Token: 0x06028A9B RID: 166555 RVA: 0x000D2948 File Offset: 0x000D0B48
		// (set) Token: 0x06028A9C RID: 166556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17006000")]
		public ActMultiV3IdentityType identityType
		{
			[Token(Token = "0x6028A9B")]
			[Address(RVA = "0x23ED4F0", Offset = "0x23EC0F0", VA = "0x1823ED4F0")]
			[CompilerGenerated]
			get
			{
				return ActMultiV3IdentityType.NONE;
			}
			[Token(Token = "0x6028A9C")]
			[Address(RVA = "0x23ED550", Offset = "0x23EC150", VA = "0x1823ED550")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06028A9D RID: 166557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A9D")]
		[Address(RVA = "0x23ECD60", Offset = "0x23EB960", VA = "0x1823ECD60")]
		public void LoadData(ActMultiV3IdentityType idType, int charInstId)
		{
		}

		// Token: 0x06028A9E RID: 166558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028A9E")]
		[Address(RVA = "0x23ECC50", Offset = "0x23EB850", VA = "0x1823ECC50")]
		public void InitSkillEquip(PlayerActivity.PlayerMultiV3Activity.SquadItem playerSquadItem)
		{
		}

		// Token: 0x06028A9F RID: 166559 RVA: 0x000D2960 File Offset: 0x000D0B60
		[Token(Token = "0x6028A9F")]
		[Address(RVA = "0x23ECB30", Offset = "0x23EB730", VA = "0x1823ECB30")]
		public int FindCurrSkillIndex()
		{
			return 0;
		}

		// Token: 0x06028AA0 RID: 166560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AA0")]
		[Address(RVA = "0x23ED170", Offset = "0x23EBD70", VA = "0x1823ED170")]
		private void _SetInstId(int instId)
		{
		}

		// Token: 0x06028AA1 RID: 166561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AA1")]
		[Address(RVA = "0x23ECF80", Offset = "0x23EBB80", VA = "0x1823ECF80")]
		public void UpdatePlayerData()
		{
		}

		// Token: 0x06028AA2 RID: 166562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AA2")]
		[Address(RVA = "0x23ED2F0", Offset = "0x23EBEF0", VA = "0x1823ED2F0")]
		private void _UpdatePlayerData(int instId)
		{
		}

		// Token: 0x06028AA3 RID: 166563 RVA: 0x000D2978 File Offset: 0x000D0B78
		[Token(Token = "0x6028AA3")]
		[Address(RVA = "0x23EC8B0", Offset = "0x23EB4B0", VA = "0x1823EC8B0")]
		public bool CheckIfMemberChanged(PlayerActivity.PlayerMultiV3Activity.SquadItem playerChar)
		{
			return default(bool);
		}

		// Token: 0x06028AA4 RID: 166564 RVA: 0x000D2990 File Offset: 0x000D0B90
		[Token(Token = "0x6028AA4")]
		[Address(RVA = "0x23ECFF0", Offset = "0x23EBBF0", VA = "0x1823ECFF0")]
		private int _FindCurrSkillIndex()
		{
			return 0;
		}

		// Token: 0x06028AA5 RID: 166565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028AA5")]
		[Address(RVA = "0x23ECA80", Offset = "0x23EB680", VA = "0x1823ECA80", Slot = "55")]
		public IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo()
		{
			return null;
		}

		// Token: 0x06028AA6 RID: 166566 RVA: 0x000D29A8 File Offset: 0x000D0BA8
		[Token(Token = "0x6028AA6")]
		[Address(RVA = "0x23ECA10", Offset = "0x23EB610", VA = "0x1823ECA10", Slot = "56")]
		public int ExtraTmplCount()
		{
			return 0;
		}

		// Token: 0x06028AA7 RID: 166567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028AA7")]
		[Address(RVA = "0x23ECB90", Offset = "0x23EB790", VA = "0x1823ECB90", Slot = "57")]
		public string GetDefaultEquipId()
		{
			return null;
		}

		// Token: 0x06028AA8 RID: 166568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028AA8")]
		[Address(RVA = "0x23ECBF0", Offset = "0x23EB7F0", VA = "0x1823ECBF0")]
		public string GetSelectEquipId()
		{
			return null;
		}

		// Token: 0x06028AA9 RID: 166569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028AA9")]
		[Address(RVA = "0x23ED490", Offset = "0x23EC090", VA = "0x1823ED490")]
		public ActMultiV3CharViewModel()
		{
		}

		// Token: 0x04039EEE RID: 237294
		[Token(Token = "0x4039EEE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_identityType;

		// Token: 0x04039EEF RID: 237295
		[Token(Token = "0x4039EEF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_identityType;

		// Token: 0x04039EF0 RID: 237296
		[Token(Token = "0x4039EF0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039EF1 RID: 237297
		[Token(Token = "0x4039EF1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitSkillEquip;

		// Token: 0x04039EF2 RID: 237298
		[Token(Token = "0x4039EF2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_FindCurrSkillIndex;

		// Token: 0x04039EF3 RID: 237299
		[Token(Token = "0x4039EF3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SetInstId;

		// Token: 0x04039EF4 RID: 237300
		[Token(Token = "0x4039EF4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_UpdatePlayerData;

		// Token: 0x04039EF5 RID: 237301
		[Token(Token = "0x4039EF5")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdatePlayerData;

		// Token: 0x04039EF6 RID: 237302
		[Token(Token = "0x4039EF6")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfMemberChanged;

		// Token: 0x04039EF7 RID: 237303
		[Token(Token = "0x4039EF7")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__FindCurrSkillIndex;

		// Token: 0x04039EF8 RID: 237304
		[Token(Token = "0x4039EF8")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ExtraTmplInfo;

		// Token: 0x04039EF9 RID: 237305
		[Token(Token = "0x4039EF9")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ExtraTmplCount;

		// Token: 0x04039EFA RID: 237306
		[Token(Token = "0x4039EFA")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_GetDefaultEquipId;

		// Token: 0x04039EFB RID: 237307
		[Token(Token = "0x4039EFB")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetSelectEquipId;

		// Token: 0x04039EFC RID: 237308
		[Token(Token = "0x4039EFC")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
