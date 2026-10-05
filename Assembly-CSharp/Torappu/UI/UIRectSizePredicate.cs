using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003857 RID: 14423
	[Token(Token = "0x2003857")]
	public class UIRectSizePredicate : MonoBehaviour
	{
		// Token: 0x06016D95 RID: 93589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D95")]
		[Address(RVA = "0xF4C1F0", Offset = "0xF4ADF0", VA = "0x180F4C1F0")]
		private void Awake()
		{
		}

		// Token: 0x06016D96 RID: 93590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D96")]
		[Address(RVA = "0xF4C240", Offset = "0xF4AE40", VA = "0x180F4C240")]
		private void Update()
		{
		}

		// Token: 0x06016D97 RID: 93591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016D97")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIRectSizePredicate()
		{
		}

		// Token: 0x0401B8E3 RID: 112867
		[Token(Token = "0x401B8E3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _targetGameObject;

		// Token: 0x0401B8E4 RID: 112868
		[Token(Token = "0x401B8E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _inactiveWidth;

		// Token: 0x0401B8E5 RID: 112869
		[Token(Token = "0x401B8E5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _activeWidth;

		// Token: 0x0401B8E6 RID: 112870
		[Token(Token = "0x401B8E6")]
		[FieldOffset(Offset = "0x28")]
		private RectTransform m_rect;
	}
}
