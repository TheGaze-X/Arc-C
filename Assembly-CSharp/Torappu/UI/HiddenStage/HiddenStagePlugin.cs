using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using UnityEngine;
using XLua;

namespace Torappu.UI.HiddenStage
{
	// Token: 0x02004CA8 RID: 19624
	[Token(Token = "0x2004CA8")]
	public class HiddenStagePlugin : StageButtonHolderPlugin
	{
		// Token: 0x0601D6A9 RID: 120489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6A9")]
		[Address(RVA = "0x170AEB0", Offset = "0x1709AB0", VA = "0x18170AEB0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601D6AA RID: 120490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6AA")]
		[Address(RVA = "0x170B210", Offset = "0x1709E10", VA = "0x18170B210", Slot = "5")]
		protected override void OnRenderStage(StageViewModel stageViewModel)
		{
		}

		// Token: 0x0601D6AB RID: 120491 RVA: 0x000AB660 File Offset: 0x000A9860
		[Token(Token = "0x601D6AB")]
		[Address(RVA = "0x170B480", Offset = "0x170A080", VA = "0x18170B480")]
		private bool _RenderLockedInfoOnInit(string stageId)
		{
			return default(bool);
		}

		// Token: 0x0601D6AC RID: 120492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6AC")]
		[Address(RVA = "0x170B080", Offset = "0x1709C80", VA = "0x18170B080")]
		public void OnPluginClick()
		{
		}

		// Token: 0x0601D6AD RID: 120493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6AD")]
		[Address(RVA = "0x170B5C0", Offset = "0x170A1C0", VA = "0x18170B5C0")]
		public HiddenStagePlugin()
		{
		}

		// Token: 0x04026BD0 RID: 158672
		[Token(Token = "0x4026BD0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Panel")]
		private GameObject _panelLocked;

		// Token: 0x04026BD1 RID: 158673
		[Token(Token = "0x4026BD1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Panel")]
		private GameObject _panelUnlock;

		// Token: 0x04026BD2 RID: 158674
		[Token(Token = "0x4026BD2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Progress")]
		private GameObject _iconProgress;

		// Token: 0x04026BD3 RID: 158675
		[Token(Token = "0x4026BD3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Progress")]
		private GameObject _iconComplete;

		// Token: 0x04026BD4 RID: 158676
		[Token(Token = "0x4026BD4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject[] _lines;

		// Token: 0x04026BD5 RID: 158677
		[Token(Token = "0x4026BD5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _panelPlugin;

		// Token: 0x04026BD6 RID: 158678
		[Token(Token = "0x4026BD6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UICommonTrackPoint _hiddenStageTrackPoint;

		// Token: 0x04026BD7 RID: 158679
		[Token(Token = "0x4026BD7")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Tooltip("This stage is used to locate current plugin to an activity while the stageself may be banned.")]
		private string _anchorStageId;

		// Token: 0x04026BD8 RID: 158680
		[Token(Token = "0x4026BD8")]
		[FieldOffset(Offset = "0x68")]
		private TrackPointViewProperty m_trackProperty;

		// Token: 0x04026BD9 RID: 158681
		[Token(Token = "0x4026BD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04026BDA RID: 158682
		[Token(Token = "0x4026BDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRenderStage;

		// Token: 0x04026BDB RID: 158683
		[Token(Token = "0x4026BDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderLockedInfoOnInit;

		// Token: 0x04026BDC RID: 158684
		[Token(Token = "0x4026BDC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPluginClick;

		// Token: 0x04026BDD RID: 158685
		[Token(Token = "0x4026BDD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
