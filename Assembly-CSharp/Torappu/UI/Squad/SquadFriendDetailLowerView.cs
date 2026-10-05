using System;
using Il2CppDummyDll;
using Torappu.UI.CharacterInfo;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Squad
{
	// Token: 0x02003E12 RID: 15890
	[Token(Token = "0x2003E12")]
	public class SquadFriendDetailLowerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018B7D RID: 101245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B7D")]
		[Address(RVA = "0x1139F10", Offset = "0x1138B10", VA = "0x181139F10")]
		public void Render(SquadAssistCharDetailModel model)
		{
		}

		// Token: 0x06018B7E RID: 101246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B7E")]
		[Address(RVA = "0x113A200", Offset = "0x1138E00", VA = "0x18113A200")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018B7F RID: 101247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B7F")]
		[Address(RVA = "0x113A3E0", Offset = "0x1138FE0", VA = "0x18113A3E0")]
		private void _OnEquipClicked(string equipId)
		{
		}

		// Token: 0x06018B80 RID: 101248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018B80")]
		[Address(RVA = "0x113A4D0", Offset = "0x11390D0", VA = "0x18113A4D0")]
		public SquadFriendDetailLowerView()
		{
		}

		// Token: 0x0401E54F RID: 124239
		[Token(Token = "0x401E54F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _eliteImage;

		// Token: 0x0401E550 RID: 124240
		[Token(Token = "0x401E550")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x0401E551 RID: 124241
		[Token(Token = "0x401E551")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _potentialImage;

		// Token: 0x0401E552 RID: 124242
		[Token(Token = "0x401E552")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _rarityImage;

		// Token: 0x0401E553 RID: 124243
		[Token(Token = "0x401E553")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _professionImage;

		// Token: 0x0401E554 RID: 124244
		[Token(Token = "0x401E554")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _charNameText;

		// Token: 0x0401E555 RID: 124245
		[Token(Token = "0x401E555")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CharacterInfoIllustWrapper _illustWrapper;

		// Token: 0x0401E556 RID: 124246
		[Token(Token = "0x401E556")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private SimpleLayoutContent _skillContent;

		// Token: 0x0401E557 RID: 124247
		[Token(Token = "0x401E557")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private SimpleLayoutContent _equipContent;

		// Token: 0x0401E558 RID: 124248
		[Token(Token = "0x401E558")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _skillLimitObject;

		// Token: 0x0401E559 RID: 124249
		[Token(Token = "0x401E559")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private UIWrappedScrollRect _equipScroll;

		// Token: 0x0401E55A RID: 124250
		[Token(Token = "0x401E55A")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x0401E55B RID: 124251
		[Token(Token = "0x401E55B")]
		[FieldOffset(Offset = "0x78")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0401E55C RID: 124252
		[Token(Token = "0x401E55C")]
		[FieldOffset(Offset = "0x88")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0401E55D RID: 124253
		[Token(Token = "0x401E55D")]
		[FieldOffset(Offset = "0x98")]
		private SquadAssistCharDetailModel m_cachedDetailModel;

		// Token: 0x0401E55E RID: 124254
		[Token(Token = "0x401E55E")]
		[FieldOffset(Offset = "0xA0")]
		private SquadFriendDetailLowerView.SkillAdapter m_skillAdapter;

		// Token: 0x0401E55F RID: 124255
		[Token(Token = "0x401E55F")]
		[FieldOffset(Offset = "0xA8")]
		private SquadFriendDetailLowerView.EquipAdapter m_equipAdapter;

		// Token: 0x0401E560 RID: 124256
		[Token(Token = "0x401E560")]
		[FieldOffset(Offset = "0xB0")]
		private int m_cachedSeqNum;

		// Token: 0x0401E561 RID: 124257
		[Token(Token = "0x401E561")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401E562 RID: 124258
		[Token(Token = "0x401E562")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401E563 RID: 124259
		[Token(Token = "0x401E563")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnEquipClicked;

		// Token: 0x0401E564 RID: 124260
		[Token(Token = "0x401E564")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02003E13 RID: 15891
		[Token(Token = "0x2003E13")]
		private class SkillAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018B81 RID: 101249 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018B81")]
			[Address(RVA = "0x1136AF0", Offset = "0x11356F0", VA = "0x181136AF0")]
			public SkillAdapter(SquadFriendDetailLowerView closure)
			{
			}

			// Token: 0x17003AE8 RID: 15080
			// (get) Token: 0x06018B82 RID: 101250 RVA: 0x0009B7F0 File Offset: 0x000999F0
			[Token(Token = "0x17003AE8")]
			public override int count
			{
				[Token(Token = "0x6018B82")]
				[Address(RVA = "0x1136B70", Offset = "0x1135770", VA = "0x181136B70", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018B83 RID: 101251 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018B83")]
			[Address(RVA = "0x11368E0", Offset = "0x11354E0", VA = "0x1811368E0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401E565 RID: 124261
			[Token(Token = "0x401E565")]
			[FieldOffset(Offset = "0x20")]
			private SquadFriendDetailLowerView m_closure;

			// Token: 0x0401E566 RID: 124262
			[Token(Token = "0x401E566")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E567 RID: 124263
			[Token(Token = "0x401E567")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E568 RID: 124264
			[Token(Token = "0x401E568")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x02003E14 RID: 15892
		[Token(Token = "0x2003E14")]
		private class EquipAdapter : SimpleLayoutAdapter
		{
			// Token: 0x06018B84 RID: 101252 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6018B84")]
			[Address(RVA = "0x1135A60", Offset = "0x1134660", VA = "0x181135A60")]
			public EquipAdapter(SquadFriendDetailLowerView closure)
			{
			}

			// Token: 0x17003AE9 RID: 15081
			// (get) Token: 0x06018B85 RID: 101253 RVA: 0x0009B808 File Offset: 0x00099A08
			[Token(Token = "0x17003AE9")]
			public override int count
			{
				[Token(Token = "0x6018B85")]
				[Address(RVA = "0x1135AE0", Offset = "0x11346E0", VA = "0x181135AE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x06018B86 RID: 101254 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6018B86")]
			[Address(RVA = "0x11357A0", Offset = "0x11343A0", VA = "0x1811357A0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0401E569 RID: 124265
			[Token(Token = "0x401E569")]
			[FieldOffset(Offset = "0x20")]
			private SquadFriendDetailLowerView m_closure;

			// Token: 0x0401E56A RID: 124266
			[Token(Token = "0x401E56A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0401E56B RID: 124267
			[Token(Token = "0x401E56B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0401E56C RID: 124268
			[Token(Token = "0x401E56C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
