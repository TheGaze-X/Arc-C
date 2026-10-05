using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x020055CA RID: 21962
	[Token(Token = "0x20055CA")]
	public class RL05ExpeditionPluginContext : RoguelikeExpeditionPluginContext
	{
		// Token: 0x17004B97 RID: 19351
		// (get) Token: 0x060203E8 RID: 132072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B97")]
		public override GameObject charCardPrefab
		{
			[Token(Token = "0x60203E8")]
			[Address(RVA = "0x1A5F300", Offset = "0x1A5DF00", VA = "0x181A5F300", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004B98 RID: 19352
		// (get) Token: 0x060203E9 RID: 132073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004B98")]
		public override RoguelikeExpeditionSelectingCharView selectingCharPrefab
		{
			[Token(Token = "0x60203E9")]
			[Address(RVA = "0x1A5F360", Offset = "0x1A5DF60", VA = "0x181A5F360", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x060203EA RID: 132074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203EA")]
		[Address(RVA = "0x1A5EDA0", Offset = "0x1A5D9A0", VA = "0x181A5EDA0", Slot = "6")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x060203EB RID: 132075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203EB")]
		[Address(RVA = "0x1A5EC60", Offset = "0x1A5D860", VA = "0x181A5EC60", Slot = "7")]
		public override string GetSelectDesc(RoguelikeExpeditionModel model)
		{
			return null;
		}

		// Token: 0x060203EC RID: 132076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203EC")]
		[Address(RVA = "0x1A5EB50", Offset = "0x1A5D750", VA = "0x181A5EB50", Slot = "8")]
		public override RoguelikeExpeditionPluginContext.RoguelikeExpeditionCharListSort GetExpeditionCharListSort(RoguelikeExpeditionModel expeditionModel)
		{
			return null;
		}

		// Token: 0x060203ED RID: 132077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203ED")]
		[Address(RVA = "0x1A5EAC0", Offset = "0x1A5D6C0", VA = "0x181A5EAC0", Slot = "9")]
		public override RoguelikeExpeditionConfirmBehaviour GetConfirmBehaviour()
		{
			return null;
		}

		// Token: 0x060203EE RID: 132078 RVA: 0x000B5080 File Offset: 0x000B3280
		[Token(Token = "0x60203EE")]
		[Address(RVA = "0x1A5E9D0", Offset = "0x1A5D5D0", VA = "0x181A5E9D0")]
		public bool CheckCharCandled(RoguelikeExpeditionCharCardViewModel charModel)
		{
			return default(bool);
		}

		// Token: 0x060203EF RID: 132079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203EF")]
		[Address(RVA = "0x1A5F0A0", Offset = "0x1A5DCA0", VA = "0x181A5F0A0")]
		private void _LoadDetailData(string topicId)
		{
		}

		// Token: 0x060203F0 RID: 132080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203F0")]
		[Address(RVA = "0x1A5F1A0", Offset = "0x1A5DDA0", VA = "0x181A5F1A0")]
		private void _LoadModuleData(string topicId)
		{
		}

		// Token: 0x060203F1 RID: 132081 RVA: 0x000B5098 File Offset: 0x000B3298
		[Token(Token = "0x60203F1")]
		[Address(RVA = "0x1A5EFD0", Offset = "0x1A5DBD0", VA = "0x181A5EFD0")]
		private int _ExpeditionCandleCharListSort(RoguelikeExpeditionCharCardViewModel lhs, RoguelikeExpeditionCharCardViewModel rhs)
		{
			return 0;
		}

		// Token: 0x060203F2 RID: 132082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60203F2")]
		[Address(RVA = "0x1A5F2A0", Offset = "0x1A5DEA0", VA = "0x181A5F2A0")]
		public RL05ExpeditionPluginContext()
		{
		}

		// Token: 0x060203F3 RID: 132083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60203F3")]
		[Address(RVA = "0x1A5EFC0", Offset = "0x1A5DBC0", VA = "0x181A5EFC0")]
		private RoguelikeExpeditionConfirmBehaviour <>xLuaBaseProxy_GetConfirmBehaviour()
		{
			return null;
		}

		// Token: 0x0402B9C3 RID: 178627
		[Token(Token = "0x402B9C3")]
		[FieldOffset(Offset = "0x18")]
		private GameObject m_charCardPrefab;

		// Token: 0x0402B9C4 RID: 178628
		[Token(Token = "0x402B9C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _charCardPrefab;

		// Token: 0x0402B9C5 RID: 178629
		[Token(Token = "0x402B9C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RoguelikeExpeditionSelectingCharView _selectingCharPrefab;

		// Token: 0x0402B9C6 RID: 178630
		[Token(Token = "0x402B9C6")]
		[FieldOffset(Offset = "0x30")]
		private string m_cachedSelectDescFormat;

		// Token: 0x0402B9C7 RID: 178631
		[Token(Token = "0x402B9C7")]
		[FieldOffset(Offset = "0x38")]
		private string m_candleBuffId;

		// Token: 0x0402B9C8 RID: 178632
		[Token(Token = "0x402B9C8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charCardPrefab;

		// Token: 0x0402B9C9 RID: 178633
		[Token(Token = "0x402B9C9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectingCharPrefab;

		// Token: 0x0402B9CA RID: 178634
		[Token(Token = "0x402B9CA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402B9CB RID: 178635
		[Token(Token = "0x402B9CB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectDesc;

		// Token: 0x0402B9CC RID: 178636
		[Token(Token = "0x402B9CC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetExpeditionCharListSort;

		// Token: 0x0402B9CD RID: 178637
		[Token(Token = "0x402B9CD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetConfirmBehaviour;

		// Token: 0x0402B9CE RID: 178638
		[Token(Token = "0x402B9CE")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckCharCandled;

		// Token: 0x0402B9CF RID: 178639
		[Token(Token = "0x402B9CF")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadDetailData;

		// Token: 0x0402B9D0 RID: 178640
		[Token(Token = "0x402B9D0")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadModuleData;

		// Token: 0x0402B9D1 RID: 178641
		[Token(Token = "0x402B9D1")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ExpeditionCandleCharListSort;

		// Token: 0x0402B9D2 RID: 178642
		[Token(Token = "0x402B9D2")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
