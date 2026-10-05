using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048A3 RID: 18595
	[Token(Token = "0x20048A3")]
	public class MissionDetailView : PageSingleComponent
	{
		// Token: 0x0601C0ED RID: 114925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0ED")]
		[Address(RVA = "0x156B3C0", Offset = "0x1569FC0", VA = "0x18156B3C0")]
		public static void RegisterFocusItem(GameObject itemCard, MissionViewModel missionData)
		{
		}

		// Token: 0x0601C0EE RID: 114926 RVA: 0x000A7160 File Offset: 0x000A5360
		[Token(Token = "0x601C0EE")]
		[Address(RVA = "0x156B220", Offset = "0x1569E20", VA = "0x18156B220")]
		private Vector3 PositionConstrain(Vector3 target, Vector3 p0, Vector3 p1)
		{
			return default(Vector3);
		}

		// Token: 0x0601C0EF RID: 114927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0EF")]
		[Address(RVA = "0x156B1A0", Offset = "0x1569DA0", VA = "0x18156B1A0")]
		public void HideView()
		{
		}

		// Token: 0x0601C0F0 RID: 114928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0F0")]
		[Address(RVA = "0x156B560", Offset = "0x156A160", VA = "0x18156B560")]
		private void _ApplyMissionView(MissionViewModel missionData)
		{
		}

		// Token: 0x0601C0F1 RID: 114929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0F1")]
		[Address(RVA = "0x156B630", Offset = "0x156A230", VA = "0x18156B630")]
		private void _UpdateLayout(GameObject taskObj)
		{
		}

		// Token: 0x0601C0F2 RID: 114930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0F2")]
		[Address(RVA = "0x156B940", Offset = "0x156A540", VA = "0x18156B940")]
		public MissionDetailView()
		{
		}

		// Token: 0x04024A47 RID: 150087
		[Token(Token = "0x4024A47")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _bound;

		// Token: 0x04024A48 RID: 150088
		[Token(Token = "0x4024A48")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _panelLocal;

		// Token: 0x04024A49 RID: 150089
		[Token(Token = "0x4024A49")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private RectTransform _taskContainer;

		// Token: 0x04024A4A RID: 150090
		[Token(Token = "0x4024A4A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private MissionProgressBar _progressBar;

		// Token: 0x04024A4B RID: 150091
		[Token(Token = "0x4024A4B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _descrption;

		// Token: 0x04024A4C RID: 150092
		[Token(Token = "0x4024A4C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _constrain0;

		// Token: 0x04024A4D RID: 150093
		[Token(Token = "0x4024A4D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Transform _constrain1;

		// Token: 0x04024A4E RID: 150094
		[Token(Token = "0x4024A4E")]
		[FieldOffset(Offset = "0x58")]
		private GameObject m_missionTask;

		// Token: 0x04024A4F RID: 150095
		[Token(Token = "0x4024A4F")]
		[FieldOffset(Offset = "0x60")]
		private MissionViewModel m_viewModel;

		// Token: 0x04024A50 RID: 150096
		[Token(Token = "0x4024A50")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RegisterFocusItem;

		// Token: 0x04024A51 RID: 150097
		[Token(Token = "0x4024A51")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PositionConstrain;

		// Token: 0x04024A52 RID: 150098
		[Token(Token = "0x4024A52")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideView;

		// Token: 0x04024A53 RID: 150099
		[Token(Token = "0x4024A53")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ApplyMissionView;

		// Token: 0x04024A54 RID: 150100
		[Token(Token = "0x4024A54")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateLayout;

		// Token: 0x04024A55 RID: 150101
		[Token(Token = "0x4024A55")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
