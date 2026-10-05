using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x0200523C RID: 21052
	[Token(Token = "0x200523C")]
	public abstract class RoguelikeFocusStatePlugin : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601F111 RID: 127249 RVA: 0x000B0CE8 File Offset: 0x000AEEE8
		[Token(Token = "0x601F111")]
		[Address(RVA = "0x18D7B20", Offset = "0x18D6720", VA = "0x1818D7B20", Slot = "4")]
		public virtual ValueBundle GetRollNodeDialogOptionExtraData(string topicId)
		{
			return default(ValueBundle);
		}

		// Token: 0x0601F112 RID: 127250 RVA: 0x000B0D00 File Offset: 0x000AEF00
		[Token(Token = "0x601F112")]
		[Address(RVA = "0x18D7BE0", Offset = "0x18D67E0", VA = "0x1818D7BE0", Slot = "5")]
		public virtual bool PassRollNodeItemChecker(string topicId, RoguelikeTopicDetail topicData, RoguelikeDungeonNode focusNode)
		{
			return default(bool);
		}

		// Token: 0x170048A8 RID: 18600
		// (get) Token: 0x0601F113 RID: 127251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048A8")]
		public virtual string noCountToast
		{
			[Token(Token = "0x601F113")]
			[Address(RVA = "0x18D7D30", Offset = "0x18D6930", VA = "0x1818D7D30", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048A9 RID: 18601
		// (get) Token: 0x0601F114 RID: 127252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048A9")]
		public virtual string rollSucToast
		{
			[Token(Token = "0x601F114")]
			[Address(RVA = "0x18D7D90", Offset = "0x18D6990", VA = "0x1818D7D90", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x170048AA RID: 18602
		// (get) Token: 0x0601F115 RID: 127253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170048AA")]
		public virtual List<ICheckNodeUnlockStrategy> dynamicCheckNodeUnlockStrategies
		{
			[Token(Token = "0x601F115")]
			[Address(RVA = "0x18D7CD0", Offset = "0x18D68D0", VA = "0x1818D7CD0", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601F116 RID: 127254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F116")]
		[Address(RVA = "0x18D7C70", Offset = "0x18D6870", VA = "0x1818D7C70")]
		protected RoguelikeFocusStatePlugin()
		{
		}

		// Token: 0x04029AA8 RID: 170664
		[Token(Token = "0x4029AA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetRollNodeDialogOptionExtraData;

		// Token: 0x04029AA9 RID: 170665
		[Token(Token = "0x4029AA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PassRollNodeItemChecker;

		// Token: 0x04029AAA RID: 170666
		[Token(Token = "0x4029AAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_noCountToast;

		// Token: 0x04029AAB RID: 170667
		[Token(Token = "0x4029AAB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_rollSucToast;

		// Token: 0x04029AAC RID: 170668
		[Token(Token = "0x4029AAC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_dynamicCheckNodeUnlockStrategies;

		// Token: 0x04029AAD RID: 170669
		[Token(Token = "0x4029AAD")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
