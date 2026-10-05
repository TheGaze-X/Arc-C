using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.Squad;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020052ED RID: 21229
	[Token(Token = "0x20052ED")]
	public class RoguelikeFriendAssistSearchView : DataBinder<RoguelikeFriendAssistSearchProperty>
	{
		// Token: 0x1700497B RID: 18811
		// (get) Token: 0x0601F501 RID: 128257 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601F502 RID: 128258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700497B")]
		public Action<PlayerRoguelikeV2.CurrentData.Recruit.FriendAssistData> onAssistItemClick
		{
			[Token(Token = "0x601F501")]
			[Address(RVA = "0x1908ED0", Offset = "0x1907AD0", VA = "0x181908ED0")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x601F502")]
			[Address(RVA = "0x1908F30", Offset = "0x1907B30", VA = "0x181908F30")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601F503 RID: 128259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F503")]
		[Address(RVA = "0x1908A10", Offset = "0x1907610", VA = "0x181908A10", Slot = "7")]
		public override void OnValueChanged(RoguelikeFriendAssistSearchProperty property)
		{
		}

		// Token: 0x0601F504 RID: 128260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F504")]
		[Address(RVA = "0x1908B50", Offset = "0x1907750", VA = "0x181908B50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F505 RID: 128261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F505")]
		[Address(RVA = "0x1908D70", Offset = "0x1907970", VA = "0x181908D70")]
		private void _OnStarFriendTabClick(bool prevState)
		{
		}

		// Token: 0x0601F506 RID: 128262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F506")]
		[Address(RVA = "0x1908E60", Offset = "0x1907A60", VA = "0x181908E60")]
		public RoguelikeFriendAssistSearchView()
		{
		}

		// Token: 0x0402A11A RID: 172314
		[Token(Token = "0x402A11A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _professionTabList;

		// Token: 0x0402A11B RID: 172315
		[Token(Token = "0x402A11B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SimpleLayoutContent _assistList;

		// Token: 0x0402A11C RID: 172316
		[Token(Token = "0x402A11C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SquadStarFriendTabView _starFriendTabView;

		// Token: 0x0402A11D RID: 172317
		[Token(Token = "0x402A11D")]
		[FieldOffset(Offset = "0x38")]
		private bool m_hasInited;

		// Token: 0x0402A11E RID: 172318
		[Token(Token = "0x402A11E")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeFriendAssistSearchView.ProfessionTabAdapter m_professionTabAdapter;

		// Token: 0x0402A11F RID: 172319
		[Token(Token = "0x402A11F")]
		[FieldOffset(Offset = "0x48")]
		private RoguelikeFriendAssistSearchView.AssistListAdapter m_assistListAdapter;

		// Token: 0x0402A120 RID: 172320
		[Token(Token = "0x402A120")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeFriendAssistSearchModel m_model;

		// Token: 0x0402A121 RID: 172321
		[Token(Token = "0x402A121")]
		[FieldOffset(Offset = "0x58")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0402A123 RID: 172323
		[Token(Token = "0x402A123")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onAssistItemClick;

		// Token: 0x0402A124 RID: 172324
		[Token(Token = "0x402A124")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onAssistItemClick;

		// Token: 0x0402A125 RID: 172325
		[Token(Token = "0x402A125")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402A126 RID: 172326
		[Token(Token = "0x402A126")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402A127 RID: 172327
		[Token(Token = "0x402A127")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnStarFriendTabClick;

		// Token: 0x0402A128 RID: 172328
		[Token(Token = "0x402A128")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020052EE RID: 21230
		[Token(Token = "0x20052EE")]
		private class ProfessionTabAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601F507 RID: 128263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F507")]
			[Address(RVA = "0x18F38E0", Offset = "0x18F24E0", VA = "0x1818F38E0")]
			public ProfessionTabAdapter(RoguelikeFriendAssistSearchView closure)
			{
			}

			// Token: 0x1700497C RID: 18812
			// (get) Token: 0x0601F508 RID: 128264 RVA: 0x000B1798 File Offset: 0x000AF998
			[Token(Token = "0x1700497C")]
			public override int count
			{
				[Token(Token = "0x601F508")]
				[Address(RVA = "0x18F3960", Offset = "0x18F2560", VA = "0x1818F3960", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601F509 RID: 128265 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F509")]
			[Address(RVA = "0x18F3650", Offset = "0x18F2250", VA = "0x1818F3650", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402A129 RID: 172329
			[Token(Token = "0x402A129")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeFriendAssistSearchView m_closure;

			// Token: 0x0402A12A RID: 172330
			[Token(Token = "0x402A12A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A12B RID: 172331
			[Token(Token = "0x402A12B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402A12C RID: 172332
			[Token(Token = "0x402A12C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020052EF RID: 21231
		[Token(Token = "0x20052EF")]
		private class AssistListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x0601F50A RID: 128266 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F50A")]
			[Address(RVA = "0x18F31F0", Offset = "0x18F1DF0", VA = "0x1818F31F0")]
			public AssistListAdapter(RoguelikeFriendAssistSearchView closure)
			{
			}

			// Token: 0x1700497D RID: 18813
			// (get) Token: 0x0601F50B RID: 128267 RVA: 0x000B17B0 File Offset: 0x000AF9B0
			[Token(Token = "0x1700497D")]
			public override int count
			{
				[Token(Token = "0x601F50B")]
				[Address(RVA = "0x18F3270", Offset = "0x18F1E70", VA = "0x1818F3270", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601F50C RID: 128268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F50C")]
			[Address(RVA = "0x18F2F00", Offset = "0x18F1B00", VA = "0x1818F2F00", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0402A12D RID: 172333
			[Token(Token = "0x402A12D")]
			[FieldOffset(Offset = "0x20")]
			private RoguelikeFriendAssistSearchView m_closure;

			// Token: 0x0402A12E RID: 172334
			[Token(Token = "0x402A12E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0402A12F RID: 172335
			[Token(Token = "0x402A12F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0402A130 RID: 172336
			[Token(Token = "0x402A130")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
