using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Torappu.Mission;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Mission
{
	// Token: 0x020048A0 RID: 18592
	[Token(Token = "0x20048A0")]
	public class MissionBookTagTab : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700429E RID: 17054
		// (get) Token: 0x0601C0E1 RID: 114913 RVA: 0x000A7148 File Offset: 0x000A5348
		[Token(Token = "0x1700429E")]
		public MissionPageType pageType
		{
			[Token(Token = "0x601C0E1")]
			[Address(RVA = "0x156B0E0", Offset = "0x1569CE0", VA = "0x18156B0E0")]
			get
			{
				return MissionPageType.STARTMISSION;
			}
		}

		// Token: 0x0601C0E2 RID: 114914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0E2")]
		[Address(RVA = "0x156AC00", Offset = "0x1569800", VA = "0x18156AC00")]
		private void OnEnable()
		{
		}

		// Token: 0x0601C0E3 RID: 114915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0E3")]
		[Address(RVA = "0x156ACA0", Offset = "0x15698A0", VA = "0x18156ACA0")]
		public void SetData(int index, MissionPageType type, string typeName, MissionBookTagTab.IParentView parentView, [Optional] Sprite icon)
		{
		}

		// Token: 0x0601C0E4 RID: 114916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0E4")]
		[Address(RVA = "0x156AFB0", Offset = "0x1569BB0", VA = "0x18156AFB0")]
		public void SetStatus(int selectedIndex)
		{
		}

		// Token: 0x0601C0E5 RID: 114917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0E5")]
		[Address(RVA = "0x156AA60", Offset = "0x1569660", VA = "0x18156AA60")]
		public void ActiveTrackPoint(bool active)
		{
		}

		// Token: 0x0601C0E6 RID: 114918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0E6")]
		[Address(RVA = "0x156AF30", Offset = "0x1569B30", VA = "0x18156AF30")]
		public void SetNewTag(bool active)
		{
		}

		// Token: 0x0601C0E7 RID: 114919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0E7")]
		[Address(RVA = "0x156AAE0", Offset = "0x15696E0", VA = "0x18156AAE0")]
		public void OnClick()
		{
		}

		// Token: 0x0601C0E8 RID: 114920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C0E8")]
		[Address(RVA = "0x156B080", Offset = "0x1569C80", VA = "0x18156B080")]
		public MissionBookTagTab()
		{
		}

		// Token: 0x04024A2D RID: 150061
		[Token(Token = "0x4024A2D")]
		private const string HOTSPOT_NAME_FORMAT = "tab_hotspot_{0}";

		// Token: 0x04024A2E RID: 150062
		[Token(Token = "0x4024A2E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Animator _selectedState;

		// Token: 0x04024A2F RID: 150063
		[Token(Token = "0x4024A2F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text[] _missionNameLabels;

		// Token: 0x04024A30 RID: 150064
		[Token(Token = "0x4024A30")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image[] _missionImages;

		// Token: 0x04024A31 RID: 150065
		[Token(Token = "0x4024A31")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _startMissionTag;

		// Token: 0x04024A32 RID: 150066
		[Token(Token = "0x4024A32")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Transform _hotspot;

		// Token: 0x04024A33 RID: 150067
		[Token(Token = "0x4024A33")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _trackPoint;

		// Token: 0x04024A34 RID: 150068
		[Token(Token = "0x4024A34")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _newTag;

		// Token: 0x04024A35 RID: 150069
		[Token(Token = "0x4024A35")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private MissionBookTagTab.IParentView m_parentView;

		// Token: 0x04024A36 RID: 150070
		[Token(Token = "0x4024A36")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private bool m_isSelected;

		// Token: 0x04024A37 RID: 150071
		[Token(Token = "0x4024A37")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
		private int m_index;

		// Token: 0x04024A38 RID: 150072
		[Token(Token = "0x4024A38")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private MissionPageType m_pageType;

		// Token: 0x04024A39 RID: 150073
		[Token(Token = "0x4024A39")]
		public const string MISSION_TAG_SELECTED = "Selected";

		// Token: 0x04024A3A RID: 150074
		[Token(Token = "0x4024A3A")]
		public const string MISSION_TAG_UNSELECTED = "Unselected";

		// Token: 0x04024A3B RID: 150075
		[Token(Token = "0x4024A3B")]
		public const string MISSION_TAG_INIT = "Unselected_End";

		// Token: 0x04024A3C RID: 150076
		[Token(Token = "0x4024A3C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pageType;

		// Token: 0x04024A3D RID: 150077
		[Token(Token = "0x4024A3D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x04024A3E RID: 150078
		[Token(Token = "0x4024A3E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04024A3F RID: 150079
		[Token(Token = "0x4024A3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetStatus;

		// Token: 0x04024A40 RID: 150080
		[Token(Token = "0x4024A40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ActiveTrackPoint;

		// Token: 0x04024A41 RID: 150081
		[Token(Token = "0x4024A41")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SetNewTag;

		// Token: 0x04024A42 RID: 150082
		[Token(Token = "0x4024A42")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x04024A43 RID: 150083
		[Token(Token = "0x4024A43")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048A1 RID: 18593
		[Token(Token = "0x20048A1")]
		public interface IParentView
		{
			// Token: 0x0601C0E9 RID: 114921
			[Token(Token = "0x601C0E9")]
			void DealWithState(int index, bool isInit);
		}
	}
}
