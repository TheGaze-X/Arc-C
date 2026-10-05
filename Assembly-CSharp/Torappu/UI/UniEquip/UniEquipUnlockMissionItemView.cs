using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.UniEquip
{
	// Token: 0x02003C4F RID: 15439
	[Token(Token = "0x2003C4F")]
	public class UniEquipUnlockMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018217 RID: 98839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018217")]
		[Address(RVA = "0x109ECC0", Offset = "0x109D8C0", VA = "0x18109ECC0")]
		public void Render(UniEquipMissionData missionData)
		{
		}

		// Token: 0x06018218 RID: 98840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018218")]
		[Address(RVA = "0x109EB70", Offset = "0x109D770", VA = "0x18109EB70")]
		public void OnMissionClick()
		{
		}

		// Token: 0x06018219 RID: 98841 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6018219")]
		[Address(RVA = "0x109F140", Offset = "0x109DD40", VA = "0x18109F140")]
		private static string _GetDescText(string missionDesc, PlayerEquipMission equipMission, bool isAccomplished)
		{
			return null;
		}

		// Token: 0x0601821A RID: 98842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601821A")]
		[Address(RVA = "0x109F280", Offset = "0x109DE80", VA = "0x18109F280")]
		public UniEquipUnlockMissionItemView()
		{
		}

		// Token: 0x0401D549 RID: 120137
		[Token(Token = "0x401D549")]
		private const string PROGRESS_COLOR = "ca580d";

		// Token: 0x0401D54A RID: 120138
		[Token(Token = "0x401D54A")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _progressMissionTitle;

		// Token: 0x0401D54B RID: 120139
		[Token(Token = "0x401D54B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _accomplishedMissionTitle;

		// Token: 0x0401D54C RID: 120140
		[Token(Token = "0x401D54C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelStageBtn;

		// Token: 0x0401D54D RID: 120141
		[Token(Token = "0x401D54D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelStageUnlock;

		// Token: 0x0401D54E RID: 120142
		[Token(Token = "0x401D54E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelStageLocked;

		// Token: 0x0401D54F RID: 120143
		[Token(Token = "0x401D54F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _missionDescText;

		// Token: 0x0401D550 RID: 120144
		[Token(Token = "0x401D550")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _missionNormalColor;

		// Token: 0x0401D551 RID: 120145
		[Token(Token = "0x401D551")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Color _accomplishedColor;

		// Token: 0x0401D552 RID: 120146
		[Token(Token = "0x401D552")]
		[FieldOffset(Offset = "0x68")]
		private StageData m_missionStageData;

		// Token: 0x0401D553 RID: 120147
		[Token(Token = "0x401D553")]
		[FieldOffset(Offset = "0x70")]
		private string m_retroName;

		// Token: 0x0401D554 RID: 120148
		[Token(Token = "0x401D554")]
		[FieldOffset(Offset = "0x78")]
		private bool m_stageUnlock;

		// Token: 0x0401D555 RID: 120149
		[Token(Token = "0x401D555")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401D556 RID: 120150
		[Token(Token = "0x401D556")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnMissionClick;

		// Token: 0x0401D557 RID: 120151
		[Token(Token = "0x401D557")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetDescText;

		// Token: 0x0401D558 RID: 120152
		[Token(Token = "0x401D558")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
