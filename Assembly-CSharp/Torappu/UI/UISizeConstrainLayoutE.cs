using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI
{
	// Token: 0x02003907 RID: 14599
	[Token(Token = "0x2003907")]
	[RequireComponent(typeof(RectTransform))]
	[DisallowMultipleComponent]
	public class UISizeConstrainLayoutE : MonoBehaviour
	{
		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x06017142 RID: 94530 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17003720")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x6017142")]
			[Address(RVA = "0xF7F590", Offset = "0xF7E190", VA = "0x180F7F590")]
			get
			{
				return null;
			}
		}

		// Token: 0x06017143 RID: 94531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017143")]
		[Address(RVA = "0xF7F280", Offset = "0xF7DE80", VA = "0x180F7F280")]
		private void Update()
		{
		}

		// Token: 0x06017144 RID: 94532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017144")]
		[Address(RVA = "0xF7F280", Offset = "0xF7DE80", VA = "0x180F7F280")]
		[Inspect(Level = 2)]
		public void UpdateLayout()
		{
		}

		// Token: 0x06017145 RID: 94533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017145")]
		[Address(RVA = "0xF7F290", Offset = "0xF7DE90", VA = "0x180F7F290")]
		private void _UpdateLayout()
		{
		}

		// Token: 0x06017146 RID: 94534 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017146")]
		[Address(RVA = "0xF7F570", Offset = "0xF7E170", VA = "0x180F7F570")]
		public UISizeConstrainLayoutE()
		{
		}

		// Token: 0x0401BD9F RID: 114079
		[Token(Token = "0x401BD9F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("Max size when scale is one")]
		private Vector2 _maxSize;

		// Token: 0x0401BDA0 RID: 114080
		[Token(Token = "0x401BDA0")]
		[FieldOffset(Offset = "0x20")]
		private RectTransform m_rectTrans;
	}
}
