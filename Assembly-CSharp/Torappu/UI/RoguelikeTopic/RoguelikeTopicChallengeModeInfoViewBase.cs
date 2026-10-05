using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044B6 RID: 17590
	[Token(Token = "0x20044B6")]
	public abstract class RoguelikeTopicChallengeModeInfoViewBase : MonoBehaviour, IHotfixable
	{
		// Token: 0x17003FC3 RID: 16323
		// (get) Token: 0x0601ADDA RID: 110042 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ADDB RID: 110043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FC3")]
		public Action onOpenDetail
		{
			[Token(Token = "0x601ADDA")]
			[Address(RVA = "0x14051E0", Offset = "0x1403DE0", VA = "0x1814051E0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601ADDB")]
			[Address(RVA = "0x14052C0", Offset = "0x1403EC0", VA = "0x1814052C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003FC4 RID: 16324
		// (get) Token: 0x0601ADDC RID: 110044 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601ADDD RID: 110045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FC4")]
		public RoguelikeTopicChallengeModeView modeView
		{
			[Token(Token = "0x601ADDC")]
			[Address(RVA = "0x1405180", Offset = "0x1403D80", VA = "0x181405180")]
			[CompilerGenerated]
			protected get
			{
				return null;
			}
			[Token(Token = "0x601ADDD")]
			[Address(RVA = "0x1405240", Offset = "0x1403E40", VA = "0x181405240")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601ADDE RID: 110046
		[Token(Token = "0x601ADDE")]
		public abstract void InitStyle(RoguelikeTopicChallengeModelStyle style);

		// Token: 0x0601ADDF RID: 110047
		[Token(Token = "0x601ADDF")]
		public abstract void Render(RoguelikeTopicModeViewModel model);

		// Token: 0x0601ADE0 RID: 110048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADE0")]
		[Address(RVA = "0x1405010", Offset = "0x1403C10", VA = "0x181405010")]
		public void EventOnOpenDetail()
		{
		}

		// Token: 0x0601ADE1 RID: 110049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ADE1")]
		[Address(RVA = "0x1405120", Offset = "0x1403D20", VA = "0x181405120")]
		protected RoguelikeTopicChallengeModeInfoViewBase()
		{
		}

		// Token: 0x040226C4 RID: 140996
		[Token(Token = "0x40226C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onOpenDetail;

		// Token: 0x040226C5 RID: 140997
		[Token(Token = "0x40226C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onOpenDetail;

		// Token: 0x040226C6 RID: 140998
		[Token(Token = "0x40226C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_modeView;

		// Token: 0x040226C7 RID: 140999
		[Token(Token = "0x40226C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_modeView;

		// Token: 0x040226C8 RID: 141000
		[Token(Token = "0x40226C8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_EventOnOpenDetail;

		// Token: 0x040226C9 RID: 141001
		[Token(Token = "0x40226C9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
