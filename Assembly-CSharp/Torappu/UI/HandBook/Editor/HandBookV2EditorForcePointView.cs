using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x0200673A RID: 26426
	[Token(Token = "0x200673A")]
	public class HandBookV2EditorForcePointView : MonoBehaviour
	{
		// Token: 0x170059C3 RID: 22979
		// (get) Token: 0x06025E5E RID: 155230 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059C3")]
		public HandBookV2PointData pointData
		{
			[Token(Token = "0x6025E5E")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025E5F RID: 155231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E5F")]
		[Address(RVA = "0x20D0CC0", Offset = "0x20CF8C0", VA = "0x1820D0CC0")]
		public void Render(HandBookV2PointData pointData, string htmlColor)
		{
		}

		// Token: 0x06025E60 RID: 155232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E60")]
		[Address(RVA = "0x20D0E40", Offset = "0x20CFA40", VA = "0x1820D0E40")]
		public void UpdateColor(Color color)
		{
		}

		// Token: 0x06025E61 RID: 155233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E61")]
		[Address(RVA = "0x20D0DE0", Offset = "0x20CF9E0", VA = "0x1820D0DE0")]
		public void ToggleHexStyle(bool isSolid)
		{
		}

		// Token: 0x06025E62 RID: 155234 RVA: 0x000C95D0 File Offset: 0x000C77D0
		[Token(Token = "0x6025E62")]
		[Address(RVA = "0x20D0AF0", Offset = "0x20CF6F0", VA = "0x1820D0AF0")]
		public bool IsInRange(Vector2 pos, out int pointIndex)
		{
			return default(bool);
		}

		// Token: 0x06025E63 RID: 155235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E63")]
		[Address(RVA = "0x20D0B80", Offset = "0x20CF780", VA = "0x1820D0B80")]
		public void OnClick()
		{
		}

		// Token: 0x06025E64 RID: 155236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E64")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookV2EditorForcePointView()
		{
		}

		// Token: 0x040354D4 RID: 218324
		[Token(Token = "0x40354D4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2AlphaHexagonView _hexView;

		// Token: 0x040354D5 RID: 218325
		[Token(Token = "0x40354D5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Material _bgMat;

		// Token: 0x040354D6 RID: 218326
		[Token(Token = "0x40354D6")]
		[FieldOffset(Offset = "0x28")]
		private HandBookV2PointData m_pointData;
	}
}
