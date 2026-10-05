using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act13Side.UI
{
	// Token: 0x02007A47 RID: 31303
	[Token(Token = "0x2007A47")]
	public class Act13SideHiddenAreaPlugin : StageButtonHolderPlugin
	{
		// Token: 0x0602BDB0 RID: 179632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDB0")]
		[Address(RVA = "0x27C9910", Offset = "0x27C8510", VA = "0x1827C9910", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602BDB1 RID: 179633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDB1")]
		[Address(RVA = "0x27C99A0", Offset = "0x27C85A0", VA = "0x1827C99A0", Slot = "5")]
		protected override void OnRenderStage(StageViewModel model)
		{
		}

		// Token: 0x0602BDB2 RID: 179634 RVA: 0x000DD6D0 File Offset: 0x000DB8D0
		[Token(Token = "0x602BDB2")]
		[Address(RVA = "0x27C9A40", Offset = "0x27C8640", VA = "0x1827C9A40")]
		private bool _RenderLockedInfoOnInit(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0602BDB3 RID: 179635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDB3")]
		[Address(RVA = "0x27C9F50", Offset = "0x27C8B50", VA = "0x1827C9F50")]
		public Act13SideHiddenAreaPlugin()
		{
		}

		// Token: 0x0403F810 RID: 260112
		[Token(Token = "0x403F810")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Text Color")]
		private Color _lockedTextColor;

		// Token: 0x0403F811 RID: 260113
		[Token(Token = "0x403F811")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Text Color")]
		private Color _unlockedTextColor;

		// Token: 0x0403F812 RID: 260114
		[Token(Token = "0x403F812")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Locked")]
		private GameObject _panelLocked;

		// Token: 0x0403F813 RID: 260115
		[Token(Token = "0x403F813")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Locked")]
		private Text[] _preposedStageText;

		// Token: 0x0403F814 RID: 260116
		[Token(Token = "0x403F814")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Locked")]
		private GameObject[] _preposedStageMark;

		// Token: 0x0403F815 RID: 260117
		[Token(Token = "0x403F815")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Locked")]
		private Text _preposedTimeInfo;

		// Token: 0x0403F816 RID: 260118
		[Token(Token = "0x403F816")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Locked")]
		private GameObject _preposedTimeMark;

		// Token: 0x0403F817 RID: 260119
		[Token(Token = "0x403F817")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Locked")]
		private GameObject _panelTimeText;

		// Token: 0x0403F818 RID: 260120
		[Token(Token = "0x403F818")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _panelUnlocked;

		// Token: 0x0403F819 RID: 260121
		[Token(Token = "0x403F819")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelPlugin;

		// Token: 0x0403F81A RID: 260122
		[Token(Token = "0x403F81A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("This stage is used to locate current plugin to an activity while the stageself may be banned.")]
		private string _anchorStageId;

		// Token: 0x0403F81B RID: 260123
		[Token(Token = "0x403F81B")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _hiddenAreaId;

		// Token: 0x0403F81C RID: 260124
		[Token(Token = "0x403F81C")]
		[FieldOffset(Offset = "0x98")]
		private ActivityTable.ActivityHiddenAreaData m_hiddenAreaData;

		// Token: 0x0403F81D RID: 260125
		[Token(Token = "0x403F81D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403F81E RID: 260126
		[Token(Token = "0x403F81E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderStage;

		// Token: 0x0403F81F RID: 260127
		[Token(Token = "0x403F81F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderLockedInfoOnInit;

		// Token: 0x0403F820 RID: 260128
		[Token(Token = "0x403F820")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
