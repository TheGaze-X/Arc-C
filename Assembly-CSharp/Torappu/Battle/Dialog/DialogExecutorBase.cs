using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Resource;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Dialog
{
	// Token: 0x02002815 RID: 10261
	[Token(Token = "0x2002815")]
	public class DialogExecutorBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x170025A3 RID: 9635
		// (get) Token: 0x06011124 RID: 69924 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025A3")]
		protected DialogController controller
		{
			[Token(Token = "0x6011124")]
			[Address(RVA = "0x8F37D0", Offset = "0x8F23D0", VA = "0x1808F37D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170025A4 RID: 9636
		// (get) Token: 0x06011125 RID: 69925 RVA: 0x00069318 File Offset: 0x00067518
		[Token(Token = "0x170025A4")]
		public virtual BattleDialogType type
		{
			[Token(Token = "0x6011125")]
			[Address(RVA = "0x8F3850", Offset = "0x8F2450", VA = "0x1808F3850", Slot = "4")]
			get
			{
				return BattleDialogType.NONE;
			}
		}

		// Token: 0x170025A5 RID: 9637
		// (get) Token: 0x06011126 RID: 69926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170025A5")]
		protected DirectAssetLoader assetLoader
		{
			[Token(Token = "0x6011126")]
			[Address(RVA = "0x8F3710", Offset = "0x8F2310", VA = "0x1808F3710")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011127 RID: 69927 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011127")]
		[Address(RVA = "0x8F34E0", Offset = "0x8F20E0", VA = "0x1808F34E0", Slot = "5")]
		public virtual Dictionary<string, BattleStoryTree.Executor> GetExecutors()
		{
			return null;
		}

		// Token: 0x06011128 RID: 69928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011128")]
		[Address(RVA = "0x8F35F0", Offset = "0x8F21F0", VA = "0x1808F35F0", Slot = "6")]
		public virtual void Init()
		{
		}

		// Token: 0x06011129 RID: 69929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011129")]
		[Address(RVA = "0x8F3650", Offset = "0x8F2250", VA = "0x1808F3650", Slot = "7")]
		public virtual void StartSignal(BattleDialogParam param)
		{
		}

		// Token: 0x0601112A RID: 69930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601112A")]
		[Address(RVA = "0x8F36B0", Offset = "0x8F22B0", VA = "0x1808F36B0")]
		public DialogExecutorBase()
		{
		}

		// Token: 0x040131F9 RID: 78329
		[Token(Token = "0x40131F9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_controller;

		// Token: 0x040131FA RID: 78330
		[Token(Token = "0x40131FA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_type;

		// Token: 0x040131FB RID: 78331
		[Token(Token = "0x40131FB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_assetLoader;

		// Token: 0x040131FC RID: 78332
		[Token(Token = "0x40131FC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetExecutors;

		// Token: 0x040131FD RID: 78333
		[Token(Token = "0x40131FD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040131FE RID: 78334
		[Token(Token = "0x40131FE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_StartSignal;

		// Token: 0x040131FF RID: 78335
		[Token(Token = "0x40131FF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
