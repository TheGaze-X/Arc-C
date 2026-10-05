using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052CA RID: 21194
	[Token(Token = "0x20052CA")]
	public class RoguelikeExpeditionCommonPluginContext : RoguelikeExpeditionPluginContext
	{
		// Token: 0x17004953 RID: 18771
		// (get) Token: 0x0601F42B RID: 128043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004953")]
		public override GameObject charCardPrefab
		{
			[Token(Token = "0x601F42B")]
			[Address(RVA = "0x18FC250", Offset = "0x18FAE50", VA = "0x1818FC250", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004954 RID: 18772
		// (get) Token: 0x0601F42C RID: 128044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004954")]
		public override RoguelikeExpeditionSelectingCharView selectingCharPrefab
		{
			[Token(Token = "0x601F42C")]
			[Address(RVA = "0x18FC2B0", Offset = "0x18FAEB0", VA = "0x1818FC2B0", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F42D RID: 128045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F42D")]
		[Address(RVA = "0x18FC0B0", Offset = "0x18FACB0", VA = "0x1818FC0B0", Slot = "6")]
		public override void LoadData(string topicId)
		{
		}

		// Token: 0x0601F42E RID: 128046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F42E")]
		[Address(RVA = "0x18FBF50", Offset = "0x18FAB50", VA = "0x1818FBF50", Slot = "7")]
		public override string GetSelectDesc(RoguelikeExpeditionModel model)
		{
			return null;
		}

		// Token: 0x0601F42F RID: 128047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F42F")]
		[Address(RVA = "0x18FBD90", Offset = "0x18FA990", VA = "0x1818FBD90", Slot = "8")]
		public override RoguelikeExpeditionPluginContext.RoguelikeExpeditionCharListSort GetExpeditionCharListSort(RoguelikeExpeditionModel expeditionModel)
		{
			return null;
		}

		// Token: 0x0601F430 RID: 128048 RVA: 0x000B1570 File Offset: 0x000AF770
		[Token(Token = "0x601F430")]
		[Address(RVA = "0x18FBB40", Offset = "0x18FA740", VA = "0x1818FBB40")]
		public static int ExpeditionCharListSort(RoguelikeExpeditionCharCardViewModel lhs, RoguelikeExpeditionCharCardViewModel rhs)
		{
			return 0;
		}

		// Token: 0x0601F431 RID: 128049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F431")]
		[Address(RVA = "0x18FC1B0", Offset = "0x18FADB0", VA = "0x1818FC1B0")]
		public RoguelikeExpeditionCommonPluginContext()
		{
		}

		// Token: 0x04029FC4 RID: 171972
		[Token(Token = "0x4029FC4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _charCardPrefab;

		// Token: 0x04029FC5 RID: 171973
		[Token(Token = "0x4029FC5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RoguelikeExpeditionSelectingCharView _selectingCharPrefab;

		// Token: 0x04029FC6 RID: 171974
		[Token(Token = "0x4029FC6")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedSelectDescFormat;

		// Token: 0x04029FC7 RID: 171975
		[Token(Token = "0x4029FC7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_charCardPrefab;

		// Token: 0x04029FC8 RID: 171976
		[Token(Token = "0x4029FC8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectingCharPrefab;

		// Token: 0x04029FC9 RID: 171977
		[Token(Token = "0x4029FC9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04029FCA RID: 171978
		[Token(Token = "0x4029FCA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectDesc;

		// Token: 0x04029FCB RID: 171979
		[Token(Token = "0x4029FCB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetExpeditionCharListSort;

		// Token: 0x04029FCC RID: 171980
		[Token(Token = "0x4029FCC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ExpeditionCharListSort;

		// Token: 0x04029FCD RID: 171981
		[Token(Token = "0x4029FCD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
