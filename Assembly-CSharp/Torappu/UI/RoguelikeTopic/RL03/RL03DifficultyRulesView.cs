using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045B7 RID: 17847
	[Token(Token = "0x20045B7")]
	public class RL03DifficultyRulesView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170040B0 RID: 16560
		// (get) Token: 0x0601B26F RID: 111215 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B270 RID: 111216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040B0")]
		public Func<string, Sprite> funcLoadBuffIcon
		{
			[Token(Token = "0x601B26F")]
			[Address(RVA = "0x1448140", Offset = "0x1446D40", VA = "0x181448140")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B270")]
			[Address(RVA = "0x1448260", Offset = "0x1446E60", VA = "0x181448260")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170040B1 RID: 16561
		// (get) Token: 0x0601B271 RID: 111217 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B272 RID: 111218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040B1")]
		public Action funcOpenOuterBuff
		{
			[Token(Token = "0x601B271")]
			[Address(RVA = "0x1448200", Offset = "0x1446E00", VA = "0x181448200")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B272")]
			[Address(RVA = "0x1448360", Offset = "0x1446F60", VA = "0x181448360")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170040B2 RID: 16562
		// (get) Token: 0x0601B273 RID: 111219 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B274 RID: 111220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170040B2")]
		public Action funcOpenColection
		{
			[Token(Token = "0x601B273")]
			[Address(RVA = "0x14481A0", Offset = "0x1446DA0", VA = "0x1814481A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B274")]
			[Address(RVA = "0x14482E0", Offset = "0x1446EE0", VA = "0x1814482E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B275 RID: 111221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B275")]
		[Address(RVA = "0x1447F20", Offset = "0x1446B20", VA = "0x181447F20")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B276 RID: 111222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B276")]
		[Address(RVA = "0x1447690", Offset = "0x1446290", VA = "0x181447690")]
		public void Render(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B277 RID: 111223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B277")]
		[Address(RVA = "0x1447AB0", Offset = "0x14466B0", VA = "0x181447AB0")]
		public void SetVisible(bool showRules)
		{
		}

		// Token: 0x0601B278 RID: 111224 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B278")]
		[Address(RVA = "0x1447E70", Offset = "0x1446A70", VA = "0x181447E70")]
		private IEnumerator _DoHide()
		{
			return null;
		}

		// Token: 0x0601B279 RID: 111225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B279")]
		[Address(RVA = "0x1447D20", Offset = "0x1446920", VA = "0x181447D20")]
		private void _CleanRT()
		{
		}

		// Token: 0x0601B27A RID: 111226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B27A")]
		[Address(RVA = "0x1447630", Offset = "0x1446230", VA = "0x181447630")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601B27B RID: 111227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B27B")]
		[Address(RVA = "0x1447520", Offset = "0x1446120", VA = "0x181447520")]
		public void EventOpenOuterBuff()
		{
		}

		// Token: 0x0601B27C RID: 111228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B27C")]
		[Address(RVA = "0x1447410", Offset = "0x1446010", VA = "0x181447410")]
		public void EventOpenCollection()
		{
		}

		// Token: 0x0601B27D RID: 111229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B27D")]
		[Address(RVA = "0x1447360", Offset = "0x1445F60", VA = "0x181447360")]
		public void EventCloseView()
		{
		}

		// Token: 0x0601B27E RID: 111230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B27E")]
		[Address(RVA = "0x1448040", Offset = "0x1446C40", VA = "0x181448040")]
		public RL03DifficultyRulesView()
		{
		}

		// Token: 0x04022F6E RID: 143214
		[Token(Token = "0x4022F6E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFadeFloatPanel _fadePanel;

		// Token: 0x04022F6F RID: 143215
		[Token(Token = "0x4022F6F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFullScreenImage _background;

		// Token: 0x04022F70 RID: 143216
		[Token(Token = "0x4022F70")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _totemDesc;

		// Token: 0x04022F71 RID: 143217
		[Token(Token = "0x4022F71")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _relicDesc;

		// Token: 0x04022F72 RID: 143218
		[Token(Token = "0x4022F72")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _buffDesc;

		// Token: 0x04022F73 RID: 143219
		[Token(Token = "0x4022F73")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _buffList;

		// Token: 0x04022F74 RID: 143220
		[Token(Token = "0x4022F74")]
		[FieldOffset(Offset = "0x48")]
		private RL03DifficultyRulesView.BuffListAdapter m_buffListAdapter;

		// Token: 0x04022F75 RID: 143221
		[Token(Token = "0x4022F75")]
		[FieldOffset(Offset = "0x50")]
		private ListDict<string, RoguelikeTopicDifficultyID> m_buffActiveInfo;

		// Token: 0x04022F76 RID: 143222
		[Token(Token = "0x4022F76")]
		[FieldOffset(Offset = "0x58")]
		private List<RL03DifficultyRulesBuffModel> m_buffList;

		// Token: 0x04022F77 RID: 143223
		[Token(Token = "0x4022F77")]
		[FieldOffset(Offset = "0x60")]
		private RoguelikeTopicModeViewProperty m_cachedProp;

		// Token: 0x04022F78 RID: 143224
		[Token(Token = "0x4022F78")]
		[FieldOffset(Offset = "0x68")]
		private Coroutine m_hideCo;

		// Token: 0x04022F7C RID: 143228
		[Token(Token = "0x4022F7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_funcLoadBuffIcon;

		// Token: 0x04022F7D RID: 143229
		[Token(Token = "0x4022F7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_funcLoadBuffIcon;

		// Token: 0x04022F7E RID: 143230
		[Token(Token = "0x4022F7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_funcOpenOuterBuff;

		// Token: 0x04022F7F RID: 143231
		[Token(Token = "0x4022F7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_funcOpenOuterBuff;

		// Token: 0x04022F80 RID: 143232
		[Token(Token = "0x4022F80")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_funcOpenColection;

		// Token: 0x04022F81 RID: 143233
		[Token(Token = "0x4022F81")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_funcOpenColection;

		// Token: 0x04022F82 RID: 143234
		[Token(Token = "0x4022F82")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022F83 RID: 143235
		[Token(Token = "0x4022F83")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022F84 RID: 143236
		[Token(Token = "0x4022F84")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x04022F85 RID: 143237
		[Token(Token = "0x4022F85")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoHide;

		// Token: 0x04022F86 RID: 143238
		[Token(Token = "0x4022F86")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CleanRT;

		// Token: 0x04022F87 RID: 143239
		[Token(Token = "0x4022F87")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04022F88 RID: 143240
		[Token(Token = "0x4022F88")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOpenOuterBuff;

		// Token: 0x04022F89 RID: 143241
		[Token(Token = "0x4022F89")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOpenCollection;

		// Token: 0x04022F8A RID: 143242
		[Token(Token = "0x4022F8A")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventCloseView;

		// Token: 0x04022F8B RID: 143243
		[Token(Token = "0x4022F8B")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020045B8 RID: 17848
		[Token(Token = "0x20045B8")]
		private class BuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x170040B3 RID: 16563
			// (get) Token: 0x0601B27F RID: 111231 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B280 RID: 111232 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170040B3")]
			public List<RL03DifficultyRulesBuffModel> buffList
			{
				[Token(Token = "0x601B27F")]
				[Address(RVA = "0x1443C80", Offset = "0x1442880", VA = "0x181443C80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601B280")]
				[Address(RVA = "0x1443F00", Offset = "0x1442B00", VA = "0x181443F00")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601B281 RID: 111233 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B281")]
			[Address(RVA = "0x1443BA0", Offset = "0x14427A0", VA = "0x181443BA0")]
			public BuffListAdapter(RL03DifficultyRulesView view)
			{
			}

			// Token: 0x170040B4 RID: 16564
			// (get) Token: 0x0601B282 RID: 111234 RVA: 0x000A4820 File Offset: 0x000A2A20
			[Token(Token = "0x170040B4")]
			public override int count
			{
				[Token(Token = "0x601B282")]
				[Address(RVA = "0x1443CE0", Offset = "0x14428E0", VA = "0x181443CE0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B283 RID: 111235 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B283")]
			[Address(RVA = "0x14438C0", Offset = "0x14424C0", VA = "0x1814438C0", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04022F8C RID: 143244
			[Token(Token = "0x4022F8C")]
			[FieldOffset(Offset = "0x20")]
			private RL03DifficultyRulesView m_view;

			// Token: 0x04022F8E RID: 143246
			[Token(Token = "0x4022F8E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_buffList;

			// Token: 0x04022F8F RID: 143247
			[Token(Token = "0x4022F8F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_buffList;

			// Token: 0x04022F90 RID: 143248
			[Token(Token = "0x4022F90")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022F91 RID: 143249
			[Token(Token = "0x4022F91")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022F92 RID: 143250
			[Token(Token = "0x4022F92")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
