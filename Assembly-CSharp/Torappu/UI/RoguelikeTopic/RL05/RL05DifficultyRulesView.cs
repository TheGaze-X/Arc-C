using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x02004594 RID: 17812
	[Token(Token = "0x2004594")]
	public class RL05DifficultyRulesView : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700409C RID: 16540
		// (get) Token: 0x0601B1CE RID: 111054 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B1CF RID: 111055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700409C")]
		public Func<string, Sprite> funcLoadBuffIcon
		{
			[Token(Token = "0x601B1CE")]
			[Address(RVA = "0x144F0F0", Offset = "0x144DCF0", VA = "0x18144F0F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B1CF")]
			[Address(RVA = "0x144F210", Offset = "0x144DE10", VA = "0x18144F210")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700409D RID: 16541
		// (get) Token: 0x0601B1D0 RID: 111056 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B1D1 RID: 111057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700409D")]
		public Action funcOpenOuterBuff
		{
			[Token(Token = "0x601B1D0")]
			[Address(RVA = "0x144F1B0", Offset = "0x144DDB0", VA = "0x18144F1B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B1D1")]
			[Address(RVA = "0x144F310", Offset = "0x144DF10", VA = "0x18144F310")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700409E RID: 16542
		// (get) Token: 0x0601B1D2 RID: 111058 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601B1D3 RID: 111059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700409E")]
		public Action funcOpenColection
		{
			[Token(Token = "0x601B1D2")]
			[Address(RVA = "0x144F150", Offset = "0x144DD50", VA = "0x18144F150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601B1D3")]
			[Address(RVA = "0x144F290", Offset = "0x144DE90", VA = "0x18144F290")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601B1D4 RID: 111060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1D4")]
		[Address(RVA = "0x144EF70", Offset = "0x144DB70", VA = "0x18144EF70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601B1D5 RID: 111061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1D5")]
		[Address(RVA = "0x144E6E0", Offset = "0x144D2E0", VA = "0x18144E6E0")]
		public void Render(RoguelikeTopicModeViewProperty property)
		{
		}

		// Token: 0x0601B1D6 RID: 111062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1D6")]
		[Address(RVA = "0x144EB00", Offset = "0x144D700", VA = "0x18144EB00")]
		public void SetVisible(bool showRules)
		{
		}

		// Token: 0x0601B1D7 RID: 111063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601B1D7")]
		[Address(RVA = "0x144EEC0", Offset = "0x144DAC0", VA = "0x18144EEC0")]
		private IEnumerator _DoHide()
		{
			return null;
		}

		// Token: 0x0601B1D8 RID: 111064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1D8")]
		[Address(RVA = "0x144ED70", Offset = "0x144D970", VA = "0x18144ED70")]
		private void _CleanRT()
		{
		}

		// Token: 0x0601B1D9 RID: 111065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1D9")]
		[Address(RVA = "0x144E680", Offset = "0x144D280", VA = "0x18144E680")]
		private void OnDestroy()
		{
		}

		// Token: 0x0601B1DA RID: 111066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1DA")]
		[Address(RVA = "0x144E570", Offset = "0x144D170", VA = "0x18144E570")]
		public void EventOpenOuterBuff()
		{
		}

		// Token: 0x0601B1DB RID: 111067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1DB")]
		[Address(RVA = "0x144E460", Offset = "0x144D060", VA = "0x18144E460")]
		public void EventOpenCollection()
		{
		}

		// Token: 0x0601B1DC RID: 111068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1DC")]
		[Address(RVA = "0x144E3B0", Offset = "0x144CFB0", VA = "0x18144E3B0")]
		public void EventCloseView()
		{
		}

		// Token: 0x0601B1DD RID: 111069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B1DD")]
		[Address(RVA = "0x144F090", Offset = "0x144DC90", VA = "0x18144F090")]
		public RL05DifficultyRulesView()
		{
		}

		// Token: 0x04022E37 RID: 142903
		[Token(Token = "0x4022E37")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIFadeFloatPanel _fadePanel;

		// Token: 0x04022E38 RID: 142904
		[Token(Token = "0x4022E38")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFullScreenImage _background;

		// Token: 0x04022E39 RID: 142905
		[Token(Token = "0x4022E39")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _copperGildDesc;

		// Token: 0x04022E3A RID: 142906
		[Token(Token = "0x4022E3A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _relicDesc;

		// Token: 0x04022E3B RID: 142907
		[Token(Token = "0x4022E3B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _buffDesc;

		// Token: 0x04022E3C RID: 142908
		[Token(Token = "0x4022E3C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private SimpleLayoutContent _buffList;

		// Token: 0x04022E3D RID: 142909
		[Token(Token = "0x4022E3D")]
		[FieldOffset(Offset = "0x48")]
		private RL05DifficultyRulesView.BuffListAdapter m_buffListAdapter;

		// Token: 0x04022E3E RID: 142910
		[Token(Token = "0x4022E3E")]
		[FieldOffset(Offset = "0x50")]
		private RoguelikeTopicModeViewProperty m_cachedProp;

		// Token: 0x04022E3F RID: 142911
		[Token(Token = "0x4022E3F")]
		[FieldOffset(Offset = "0x58")]
		private Coroutine m_hideCo;

		// Token: 0x04022E43 RID: 142915
		[Token(Token = "0x4022E43")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_funcLoadBuffIcon;

		// Token: 0x04022E44 RID: 142916
		[Token(Token = "0x4022E44")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_funcLoadBuffIcon;

		// Token: 0x04022E45 RID: 142917
		[Token(Token = "0x4022E45")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_funcOpenOuterBuff;

		// Token: 0x04022E46 RID: 142918
		[Token(Token = "0x4022E46")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_funcOpenOuterBuff;

		// Token: 0x04022E47 RID: 142919
		[Token(Token = "0x4022E47")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_funcOpenColection;

		// Token: 0x04022E48 RID: 142920
		[Token(Token = "0x4022E48")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_funcOpenColection;

		// Token: 0x04022E49 RID: 142921
		[Token(Token = "0x4022E49")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022E4A RID: 142922
		[Token(Token = "0x4022E4A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04022E4B RID: 142923
		[Token(Token = "0x4022E4B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x04022E4C RID: 142924
		[Token(Token = "0x4022E4C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__DoHide;

		// Token: 0x04022E4D RID: 142925
		[Token(Token = "0x4022E4D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CleanRT;

		// Token: 0x04022E4E RID: 142926
		[Token(Token = "0x4022E4E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04022E4F RID: 142927
		[Token(Token = "0x4022E4F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOpenOuterBuff;

		// Token: 0x04022E50 RID: 142928
		[Token(Token = "0x4022E50")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventOpenCollection;

		// Token: 0x04022E51 RID: 142929
		[Token(Token = "0x4022E51")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventCloseView;

		// Token: 0x04022E52 RID: 142930
		[Token(Token = "0x4022E52")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004595 RID: 17813
		[Token(Token = "0x2004595")]
		private class BuffListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x1700409F RID: 16543
			// (get) Token: 0x0601B1DE RID: 111070 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0601B1DF RID: 111071 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700409F")]
			public List<RL05DifficultyRulesBuffModel> buffList
			{
				[Token(Token = "0x601B1DE")]
				[Address(RVA = "0x1443C20", Offset = "0x1442820", VA = "0x181443C20")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x601B1DF")]
				[Address(RVA = "0x1443F80", Offset = "0x1442B80", VA = "0x181443F80")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x0601B1E0 RID: 111072 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601B1E0")]
			[Address(RVA = "0x1443B20", Offset = "0x1442720", VA = "0x181443B20")]
			public BuffListAdapter(RL05DifficultyRulesView view)
			{
			}

			// Token: 0x170040A0 RID: 16544
			// (get) Token: 0x0601B1E1 RID: 111073 RVA: 0x000A46A0 File Offset: 0x000A28A0
			[Token(Token = "0x170040A0")]
			public override int count
			{
				[Token(Token = "0x601B1E1")]
				[Address(RVA = "0x1443DF0", Offset = "0x14429F0", VA = "0x181443DF0", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0601B1E2 RID: 111074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601B1E2")]
			[Address(RVA = "0x1443660", Offset = "0x1442260", VA = "0x181443660", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x04022E53 RID: 142931
			[Token(Token = "0x4022E53")]
			[FieldOffset(Offset = "0x20")]
			private RL05DifficultyRulesView m_view;

			// Token: 0x04022E55 RID: 142933
			[Token(Token = "0x4022E55")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_buffList;

			// Token: 0x04022E56 RID: 142934
			[Token(Token = "0x4022E56")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_set_buffList;

			// Token: 0x04022E57 RID: 142935
			[Token(Token = "0x4022E57")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04022E58 RID: 142936
			[Token(Token = "0x4022E58")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04022E59 RID: 142937
			[Token(Token = "0x4022E59")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_RenderView;
		}
	}
}
