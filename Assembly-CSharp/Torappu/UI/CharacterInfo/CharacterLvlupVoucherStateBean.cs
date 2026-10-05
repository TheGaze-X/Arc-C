using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F1D RID: 24349
	[Token(Token = "0x2005F1D")]
	public class CharacterLvlupVoucherStateBean : MonoBehaviour, IStateBean, IHotfixable, IDataBindWrapper
	{
		// Token: 0x17005368 RID: 21352
		// (get) Token: 0x06023459 RID: 144473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005368")]
		public string charId
		{
			[Token(Token = "0x6023459")]
			[Address(RVA = "0x1DCC220", Offset = "0x1DCAE20", VA = "0x181DCC220")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005369 RID: 21353
		// (get) Token: 0x0602345A RID: 144474 RVA: 0x000C06A8 File Offset: 0x000BE8A8
		// (set) Token: 0x0602345B RID: 144475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005369")]
		public int originLevel
		{
			[Token(Token = "0x602345A")]
			[Address(RVA = "0x1DCC280", Offset = "0x1DCAE80", VA = "0x181DCC280")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x602345B")]
			[Address(RVA = "0x1DCC2E0", Offset = "0x1DCAEE0", VA = "0x181DCC2E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0602345C RID: 144476 RVA: 0x000C06C0 File Offset: 0x000BE8C0
		[Token(Token = "0x602345C")]
		[Address(RVA = "0x1DCBAC0", Offset = "0x1DCA6C0", VA = "0x181DCBAC0")]
		public CharQuery GetCharQuery()
		{
			return default(CharQuery);
		}

		// Token: 0x0602345D RID: 144477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602345D")]
		[Address(RVA = "0x1DCBB40", Offset = "0x1DCA740", VA = "0x181DCBB40")]
		public List<CharacterData.UniqueEquipPair> GetEquipQueries()
		{
			return null;
		}

		// Token: 0x0602345E RID: 144478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602345E")]
		[Address(RVA = "0x1DCBBA0", Offset = "0x1DCA7A0", VA = "0x181DCBBA0")]
		public void LoadData(CharacterLvlupPage.Param param)
		{
		}

		// Token: 0x0602345F RID: 144479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602345F")]
		[Address(RVA = "0x1DCC020", Offset = "0x1DCAC20", VA = "0x181DCC020")]
		public CharacterLvlupVoucherStateBean()
		{
		}

		// Token: 0x040309E6 RID: 199142
		[Token(Token = "0x40309E6")]
		[FieldOffset(Offset = "0x18")]
		public CharacterIllustViewProperty illustProperty;

		// Token: 0x040309E7 RID: 199143
		[Token(Token = "0x40309E7")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public CharacterLvlupVoucherViewProperty voucherViewProperty;

		// Token: 0x040309E8 RID: 199144
		[Token(Token = "0x40309E8")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public int charInstId;

		// Token: 0x040309E9 RID: 199145
		[Token(Token = "0x40309E9")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public string voucherItemId;

		// Token: 0x040309EA RID: 199146
		[Token(Token = "0x40309EA")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public int voucherItemInstId;

		// Token: 0x040309EB RID: 199147
		[Token(Token = "0x40309EB")]
		[FieldOffset(Offset = "0x40")]
		private CharQuery m_charQuery;

		// Token: 0x040309EC RID: 199148
		[Token(Token = "0x40309EC")]
		[FieldOffset(Offset = "0x58")]
		private List<CharacterData.UniqueEquipPair> m_equipPairs;

		// Token: 0x040309EE RID: 199150
		[Token(Token = "0x40309EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charId;

		// Token: 0x040309EF RID: 199151
		[Token(Token = "0x40309EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_originLevel;

		// Token: 0x040309F0 RID: 199152
		[Token(Token = "0x40309F0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_originLevel;

		// Token: 0x040309F1 RID: 199153
		[Token(Token = "0x40309F1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCharQuery;

		// Token: 0x040309F2 RID: 199154
		[Token(Token = "0x40309F2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetEquipQueries;

		// Token: 0x040309F3 RID: 199155
		[Token(Token = "0x40309F3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040309F4 RID: 199156
		[Token(Token = "0x40309F4")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
