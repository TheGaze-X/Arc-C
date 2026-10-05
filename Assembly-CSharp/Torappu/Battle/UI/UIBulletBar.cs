using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003374 RID: 13172
	[Token(Token = "0x2003374")]
	public class UIBulletBar : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601503D RID: 86077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601503D")]
		[Address(RVA = "0xD6E650", Offset = "0xD6D250", VA = "0x180D6E650")]
		private void Awake()
		{
		}

		// Token: 0x0601503E RID: 86078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601503E")]
		[Address(RVA = "0xD6E800", Offset = "0xD6D400", VA = "0x180D6E800")]
		public void ShowBulletCount(float maxCount, float curCount)
		{
		}

		// Token: 0x0601503F RID: 86079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601503F")]
		[Address(RVA = "0xD6EAF0", Offset = "0xD6D6F0", VA = "0x180D6EAF0")]
		public UIBulletBar()
		{
		}

		// Token: 0x04019011 RID: 102417
		[Token(Token = "0x4019011")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIImageOnPopulateMesh _image;

		// Token: 0x04019012 RID: 102418
		[Token(Token = "0x4019012")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _gapFactor;

		// Token: 0x04019013 RID: 102419
		[Token(Token = "0x4019013")]
		private const float PER_GAP_COUNT = 5f;

		// Token: 0x04019014 RID: 102420
		[Token(Token = "0x4019014")]
		private const int USE_SMOOTH_COUNT = 10;

		// Token: 0x04019015 RID: 102421
		[Token(Token = "0x4019015")]
		private const int IGNORE_GAP_COUNT = 40;

		// Token: 0x04019016 RID: 102422
		[Token(Token = "0x4019016")]
		[FieldOffset(Offset = "0x24")]
		private Color m_color;

		// Token: 0x04019017 RID: 102423
		[Token(Token = "0x4019017")]
		[FieldOffset(Offset = "0x34")]
		private int m_useSmoothCnt;

		// Token: 0x04019018 RID: 102424
		[Token(Token = "0x4019018")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x04019019 RID: 102425
		[Token(Token = "0x4019019")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowBulletCount;

		// Token: 0x0401901A RID: 102426
		[Token(Token = "0x401901A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
