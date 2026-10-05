using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side
{
	// Token: 0x02007A3C RID: 31292
	[Token(Token = "0x2007A3C")]
	public class Act13sideMissionStateBtn : MonoBehaviour, IHotfixable
	{
		// Token: 0x0602BD86 RID: 179590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD86")]
		[Address(RVA = "0x27CDEA0", Offset = "0x27CCAA0", VA = "0x1827CDEA0")]
		public void HandleActive(bool active)
		{
		}

		// Token: 0x0602BD87 RID: 179591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BD87")]
		[Address(RVA = "0x27CE1B0", Offset = "0x27CCDB0", VA = "0x1827CE1B0")]
		public Act13sideMissionStateBtn()
		{
		}

		// Token: 0x0403F7A1 RID: 260001
		[Token(Token = "0x403F7A1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _btnActive;

		// Token: 0x0403F7A2 RID: 260002
		[Token(Token = "0x403F7A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403F7A3 RID: 260003
		[Token(Token = "0x403F7A3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _moveTrans;

		// Token: 0x0403F7A4 RID: 260004
		[Token(Token = "0x403F7A4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _direction;

		// Token: 0x0403F7A5 RID: 260005
		[Token(Token = "0x403F7A5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _hideObj;

		// Token: 0x0403F7A6 RID: 260006
		[Token(Token = "0x403F7A6")]
		private const float TWEEN_DURATION = 0.15f;

		// Token: 0x0403F7A7 RID: 260007
		[Token(Token = "0x403F7A7")]
		private const float DELTA_POS = 300f;

		// Token: 0x0403F7A8 RID: 260008
		[Token(Token = "0x403F7A8")]
		[FieldOffset(Offset = "0x40")]
		private float m_cacheVal;

		// Token: 0x0403F7A9 RID: 260009
		[Token(Token = "0x403F7A9")]
		[FieldOffset(Offset = "0x44")]
		private bool m_isInited;

		// Token: 0x0403F7AA RID: 260010
		[Token(Token = "0x403F7AA")]
		[FieldOffset(Offset = "0x48")]
		private Tween m_tween;

		// Token: 0x0403F7AB RID: 260011
		[Token(Token = "0x403F7AB")]
		[FieldOffset(Offset = "0x50")]
		private Vector2 m_cachePos;

		// Token: 0x0403F7AC RID: 260012
		[Token(Token = "0x403F7AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleActive;

		// Token: 0x0403F7AD RID: 260013
		[Token(Token = "0x403F7AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
