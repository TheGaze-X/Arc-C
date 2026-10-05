using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.VoucherEvolve
{
	// Token: 0x02003B99 RID: 15257
	[Token(Token = "0x2003B99")]
	public class VoucherEvolveStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06017E70 RID: 97904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E70")]
		[Address(RVA = "0x1024620", Offset = "0x1023220", VA = "0x181024620")]
		public void LoadData(CharacterCardViewModel cardViewModel, UIItemViewModel itemViewModel, EvolvePhase targetEvolve)
		{
		}

		// Token: 0x06017E71 RID: 97905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017E71")]
		[Address(RVA = "0x1024870", Offset = "0x1023470", VA = "0x181024870")]
		public VoucherEvolveStateBean()
		{
		}

		// Token: 0x0401CE8A RID: 118410
		[Token(Token = "0x401CE8A")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public CharacterCardViewModel charViewModel;

		// Token: 0x0401CE8B RID: 118411
		[Token(Token = "0x401CE8B")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public UIItemViewModel itemViewModel;

		// Token: 0x0401CE8C RID: 118412
		[Token(Token = "0x401CE8C")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public EvolvePhase targetEvolvePhase;

		// Token: 0x0401CE8D RID: 118413
		[Token(Token = "0x401CE8D")]
		[FieldOffset(Offset = "0x2C")]
		[NonSerialized]
		public int chrInstId;

		// Token: 0x0401CE8E RID: 118414
		[Token(Token = "0x401CE8E")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public string charId;

		// Token: 0x0401CE8F RID: 118415
		[Token(Token = "0x401CE8F")]
		[FieldOffset(Offset = "0x38")]
		[NonSerialized]
		public CharUISkinStruct oldSkinStruct;

		// Token: 0x0401CE90 RID: 118416
		[Token(Token = "0x401CE90")]
		[FieldOffset(Offset = "0x50")]
		[NonSerialized]
		public CharUISkinStruct newSkinStruct;

		// Token: 0x0401CE91 RID: 118417
		[Token(Token = "0x401CE91")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public RarityRank rarity;

		// Token: 0x0401CE92 RID: 118418
		[Token(Token = "0x401CE92")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public string nickName;

		// Token: 0x0401CE93 RID: 118419
		[Token(Token = "0x401CE93")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public string realName;

		// Token: 0x0401CE94 RID: 118420
		[Token(Token = "0x401CE94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0401CE95 RID: 118421
		[Token(Token = "0x401CE95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
