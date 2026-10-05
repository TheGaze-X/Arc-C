using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x020033E1 RID: 13281
	[Token(Token = "0x20033E1")]
	public class UICooperateFortressEdgePanel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06015337 RID: 86839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015337")]
		[Address(RVA = "0xDA4BC0", Offset = "0xDA37C0", VA = "0x180DA4BC0")]
		private void Start()
		{
		}

		// Token: 0x06015338 RID: 86840 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015338")]
		[Address(RVA = "0xDA4D50", Offset = "0xDA3950", VA = "0x180DA4D50")]
		private void Update()
		{
		}

		// Token: 0x06015339 RID: 86841 RVA: 0x0008AA50 File Offset: 0x00088C50
		[Token(Token = "0x6015339")]
		[Address(RVA = "0xDA4380", Offset = "0xDA2F80", VA = "0x180DA4380")]
		public int AttachMark(Transform pos, int type)
		{
			return 0;
		}

		// Token: 0x0601533A RID: 86842 RVA: 0x0008AA68 File Offset: 0x00088C68
		[Token(Token = "0x601533A")]
		[Address(RVA = "0xDA48D0", Offset = "0xDA34D0", VA = "0x180DA48D0")]
		private int SetMark(List<UICooperateEdgePinMark> setsList, int type, UICooperateEdgePinMark prefab, Transform pos)
		{
			return 0;
		}

		// Token: 0x0601533B RID: 86843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601533B")]
		[Address(RVA = "0xDA4800", Offset = "0xDA3400", VA = "0x180DA4800")]
		public void DetachMark(int markNum, bool isEnemy = false)
		{
		}

		// Token: 0x0601533C RID: 86844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601533C")]
		[Address(RVA = "0xDA4500", Offset = "0xDA3100", VA = "0x180DA4500")]
		public void DetachMark(Transform markPos, bool isEnemy = false)
		{
		}

		// Token: 0x0601533D RID: 86845 RVA: 0x0008AA80 File Offset: 0x00088C80
		[Token(Token = "0x601533D")]
		[Address(RVA = "0xDA5100", Offset = "0xDA3D00", VA = "0x180DA5100")]
		private bool _EdgeMarkUpdate(UICooperateEdgePinMark mark, out Vector3 interactPos, out float angle)
		{
			return default(bool);
		}

		// Token: 0x0601533E RID: 86846 RVA: 0x0008AA98 File Offset: 0x00088C98
		[Token(Token = "0x601533E")]
		[Address(RVA = "0xDA59B0", Offset = "0xDA45B0", VA = "0x180DA59B0")]
		private bool _LineLineIntersection(out Vector3 intersection, Vector3 linePoint1, Vector3 lineVec1, Vector3 linePoint2, Vector3 lineVec2)
		{
			return default(bool);
		}

		// Token: 0x0601533F RID: 86847 RVA: 0x0008AAB0 File Offset: 0x00088CB0
		[Token(Token = "0x601533F")]
		[Address(RVA = "0xDA5880", Offset = "0xDA4480", VA = "0x180DA5880")]
		private float _GetRotate(Vector2 start, Vector2 end)
		{
			return 0f;
		}

		// Token: 0x06015340 RID: 86848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015340")]
		[Address(RVA = "0xDA5D40", Offset = "0xDA4940", VA = "0x180DA5D40")]
		public UICooperateFortressEdgePanel()
		{
		}

		// Token: 0x040194D4 RID: 103636
		[Token(Token = "0x40194D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<RectTransform> _edgePoints;

		// Token: 0x040194D5 RID: 103637
		[Token(Token = "0x40194D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _markTransform;

		// Token: 0x040194D6 RID: 103638
		[Token(Token = "0x40194D6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICooperateEdgePinMark _markPrefab;

		// Token: 0x040194D7 RID: 103639
		[Token(Token = "0x40194D7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICooperateEdgePinMark _markPrefabEnemy;

		// Token: 0x040194D8 RID: 103640
		[Token(Token = "0x40194D8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UICooperateEdgePinMark _markBoatItem;

		// Token: 0x040194D9 RID: 103641
		[Token(Token = "0x40194D9")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UICooperateEdgePinMark _markBoatEnemy;

		// Token: 0x040194DA RID: 103642
		[Token(Token = "0x40194DA")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _center;

		// Token: 0x040194DB RID: 103643
		[Token(Token = "0x40194DB")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private float _speed;

		// Token: 0x040194DC RID: 103644
		[Token(Token = "0x40194DC")]
		[FieldOffset(Offset = "0x58")]
		private List<UICooperateEdgePinMark> m_marks;

		// Token: 0x040194DD RID: 103645
		[Token(Token = "0x40194DD")]
		[FieldOffset(Offset = "0x60")]
		private List<UICooperateEdgePinMark> m_marksEnemy;

		// Token: 0x040194DE RID: 103646
		[Token(Token = "0x40194DE")]
		[FieldOffset(Offset = "0x68")]
		private Vector2 m_screenPos;

		// Token: 0x040194DF RID: 103647
		[Token(Token = "0x40194DF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x040194E0 RID: 103648
		[Token(Token = "0x40194E0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040194E1 RID: 103649
		[Token(Token = "0x40194E1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AttachMark;

		// Token: 0x040194E2 RID: 103650
		[Token(Token = "0x40194E2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetMark;

		// Token: 0x040194E3 RID: 103651
		[Token(Token = "0x40194E3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DetachMark;

		// Token: 0x040194E4 RID: 103652
		[Token(Token = "0x40194E4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix1_DetachMark;

		// Token: 0x040194E5 RID: 103653
		[Token(Token = "0x40194E5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__EdgeMarkUpdate;

		// Token: 0x040194E6 RID: 103654
		[Token(Token = "0x40194E6")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LineLineIntersection;

		// Token: 0x040194E7 RID: 103655
		[Token(Token = "0x40194E7")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetRotate;

		// Token: 0x040194E8 RID: 103656
		[Token(Token = "0x40194E8")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
