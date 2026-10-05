using System;
using System.Collections;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3.Prepare
{
	// Token: 0x0200703B RID: 28731
	[Token(Token = "0x200703B")]
	public class ActMultiV3PrepareMainCharCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700605B RID: 24667
		// (set) Token: 0x06028C8E RID: 167054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700605B")]
		public bool enableClick
		{
			[Token(Token = "0x6028C8E")]
			[Address(RVA = "0x2405850", Offset = "0x2404450", VA = "0x182405850")]
			set
			{
			}
		}

		// Token: 0x1700605C RID: 24668
		// (set) Token: 0x06028C8F RID: 167055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700605C")]
		public Action<int> onClick
		{
			[Token(Token = "0x6028C8F")]
			[Address(RVA = "0x24058E0", Offset = "0x24044E0", VA = "0x1824058E0")]
			set
			{
			}
		}

		// Token: 0x1700605D RID: 24669
		// (set) Token: 0x06028C90 RID: 167056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700605D")]
		public Action onSkip
		{
			[Token(Token = "0x6028C90")]
			[Address(RVA = "0x2405960", Offset = "0x2404560", VA = "0x182405960")]
			set
			{
			}
		}

		// Token: 0x1700605E RID: 24670
		// (get) Token: 0x06028C91 RID: 167057 RVA: 0x000D2FF0 File Offset: 0x000D11F0
		// (set) Token: 0x06028C92 RID: 167058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700605E")]
		public bool tempTagValid
		{
			[Token(Token = "0x6028C91")]
			[Address(RVA = "0x24057F0", Offset = "0x24043F0", VA = "0x1824057F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6028C92")]
			[Address(RVA = "0x24059E0", Offset = "0x24045E0", VA = "0x1824059E0")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		// Token: 0x06028C93 RID: 167059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C93")]
		[Address(RVA = "0x2405330", Offset = "0x2403F30", VA = "0x182405330")]
		public void RenderCard(ActMultiV3PrepareMainCharCardModel model)
		{
		}

		// Token: 0x06028C94 RID: 167060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C94")]
		[Address(RVA = "0x24055B0", Offset = "0x24041B0", VA = "0x1824055B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06028C95 RID: 167061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C95")]
		[Address(RVA = "0x2405100", Offset = "0x2403D00", VA = "0x182405100")]
		public void EventOnClick()
		{
		}

		// Token: 0x06028C96 RID: 167062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C96")]
		[Address(RVA = "0x2405190", Offset = "0x2403D90", VA = "0x182405190")]
		public void EventOnSkipClick()
		{
		}

		// Token: 0x06028C97 RID: 167063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6028C97")]
		[Address(RVA = "0x24056E0", Offset = "0x24042E0", VA = "0x1824056E0")]
		private IEnumerator _ResumeSkipBtn()
		{
			return null;
		}

		// Token: 0x06028C98 RID: 167064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028C98")]
		[Address(RVA = "0x2405790", Offset = "0x2404390", VA = "0x182405790")]
		public ActMultiV3PrepareMainCharCard()
		{
		}

		// Token: 0x0403A25D RID: 238173
		[Token(Token = "0x403A25D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TwoStateToggle _cardToggle;

		// Token: 0x0403A25E RID: 238174
		[Token(Token = "0x403A25E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Char")]
		private ActMultiV3CharCardBase _cardPrefab;

		// Token: 0x0403A25F RID: 238175
		[Token(Token = "0x403A25F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Char")]
		private Transform _container;

		// Token: 0x0403A260 RID: 238176
		[Token(Token = "0x403A260")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Char")]
		private UIColorGraphic _btnGraphic;

		// Token: 0x0403A261 RID: 238177
		[Token(Token = "0x403A261")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Char")]
		private GameObject _disactiveFlag;

		// Token: 0x0403A262 RID: 238178
		[Token(Token = "0x403A262")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Skip")]
		private TwoStateToggle _btnSkip;

		// Token: 0x0403A263 RID: 238179
		[Token(Token = "0x403A263")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Skip")]
		private Text _skipNum;

		// Token: 0x0403A264 RID: 238180
		[Token(Token = "0x403A264")]
		[FieldOffset(Offset = "0x50")]
		private ActMultiV3CharCardBase m_card;

		// Token: 0x0403A265 RID: 238181
		[Token(Token = "0x403A265")]
		[FieldOffset(Offset = "0x58")]
		private Action<int> m_clickListener;

		// Token: 0x0403A266 RID: 238182
		[Token(Token = "0x403A266")]
		[FieldOffset(Offset = "0x60")]
		private ActMultiV3PrepareMainCharCardModel m_cachedModel;

		// Token: 0x0403A267 RID: 238183
		[Token(Token = "0x403A267")]
		[FieldOffset(Offset = "0x68")]
		private Action m_confirmSkip;

		// Token: 0x0403A268 RID: 238184
		[Token(Token = "0x403A268")]
		[FieldOffset(Offset = "0x70")]
		private Coroutine m_skipResumeCoroutine;

		// Token: 0x0403A269 RID: 238185
		[Token(Token = "0x403A269")]
		private const float BTN_SKIP_RESUME_DELAY = 5f;

		// Token: 0x0403A26B RID: 238187
		[Token(Token = "0x403A26B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_enableClick;

		// Token: 0x0403A26C RID: 238188
		[Token(Token = "0x403A26C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClick;

		// Token: 0x0403A26D RID: 238189
		[Token(Token = "0x403A26D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_onSkip;

		// Token: 0x0403A26E RID: 238190
		[Token(Token = "0x403A26E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_tempTagValid;

		// Token: 0x0403A26F RID: 238191
		[Token(Token = "0x403A26F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_tempTagValid;

		// Token: 0x0403A270 RID: 238192
		[Token(Token = "0x403A270")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RenderCard;

		// Token: 0x0403A271 RID: 238193
		[Token(Token = "0x403A271")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403A272 RID: 238194
		[Token(Token = "0x403A272")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnClick;

		// Token: 0x0403A273 RID: 238195
		[Token(Token = "0x403A273")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnSkipClick;

		// Token: 0x0403A274 RID: 238196
		[Token(Token = "0x403A274")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ResumeSkipBtn;

		// Token: 0x0403A275 RID: 238197
		[Token(Token = "0x403A275")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
