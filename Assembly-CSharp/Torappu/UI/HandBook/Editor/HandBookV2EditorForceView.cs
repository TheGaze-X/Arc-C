using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x0200673B RID: 26427
	[Token(Token = "0x200673B")]
	public class HandBookV2EditorForceView : MonoBehaviour
	{
		// Token: 0x170059C4 RID: 22980
		// (get) Token: 0x06025E65 RID: 155237 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025E66 RID: 155238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059C4")]
		public HandBookV2ForceData forceData
		{
			[Token(Token = "0x6025E65")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6025E66")]
			[Address(RVA = "0x4E6EB0", Offset = "0x4E5AB0", VA = "0x1804E6EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170059C5 RID: 22981
		// (get) Token: 0x06025E67 RID: 155239 RVA: 0x000C95E8 File Offset: 0x000C77E8
		[Token(Token = "0x170059C5")]
		public int currentPointCount
		{
			[Token(Token = "0x6025E67")]
			[Address(RVA = "0x20D19F0", Offset = "0x20D05F0", VA = "0x1820D19F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170059C6 RID: 22982
		// (get) Token: 0x06025E68 RID: 155240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059C6")]
		public string editColor
		{
			[Token(Token = "0x6025E68")]
			[Address(RVA = "0x20D1A40", Offset = "0x20D0640", VA = "0x1820D1A40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025E69 RID: 155241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E69")]
		[Address(RVA = "0x20D13D0", Offset = "0x20CFFD0", VA = "0x1820D13D0")]
		public void Render(HandBookV2ForceData data, bool isTemp = false)
		{
		}

		// Token: 0x06025E6A RID: 155242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E6A")]
		[Address(RVA = "0x20D1830", Offset = "0x20D0430", VA = "0x1820D1830")]
		private void _RenderLogo(HandBookV2ForceData forceData)
		{
		}

		// Token: 0x06025E6B RID: 155243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E6B")]
		[Address(RVA = "0x20D1810", Offset = "0x20D0410", VA = "0x1820D1810")]
		private void _RenderBg(HandBookV2ForceData forceData)
		{
		}

		// Token: 0x06025E6C RID: 155244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E6C")]
		[Address(RVA = "0x20D17E0", Offset = "0x20D03E0", VA = "0x1820D17E0")]
		public void UpdateColor(Color? color)
		{
		}

		// Token: 0x06025E6D RID: 155245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E6D")]
		[Address(RVA = "0x20D16B0", Offset = "0x20D02B0", VA = "0x1820D16B0")]
		public void SetLogoRaycast(bool canRaycast)
		{
		}

		// Token: 0x06025E6E RID: 155246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E6E")]
		[Address(RVA = "0x20D1680", Offset = "0x20D0280", VA = "0x1820D1680")]
		public void SetBgRaycast(bool canRaycast)
		{
		}

		// Token: 0x06025E6F RID: 155247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E6F")]
		[Address(RVA = "0x20D1700", Offset = "0x20D0300", VA = "0x1820D1700")]
		public void SetSelectLogo(bool isSelected)
		{
		}

		// Token: 0x06025E70 RID: 155248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E70")]
		[Address(RVA = "0x20D16E0", Offset = "0x20D02E0", VA = "0x1820D16E0")]
		public void SetSelectBg(bool isSelected)
		{
		}

		// Token: 0x06025E71 RID: 155249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E71")]
		[Address(RVA = "0x20D16E0", Offset = "0x20D02E0", VA = "0x1820D16E0")]
		public void ToggleBgStyle(bool isSolid)
		{
		}

		// Token: 0x06025E72 RID: 155250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E72")]
		[Address(RVA = "0x20D1730", Offset = "0x20D0330", VA = "0x1820D1730")]
		public void TogglePointBgStyle(int pointIdx, bool isSolid)
		{
		}

		// Token: 0x06025E73 RID: 155251 RVA: 0x000C9600 File Offset: 0x000C7800
		[Token(Token = "0x6025E73")]
		[Address(RVA = "0x20D0EE0", Offset = "0x20CFAE0", VA = "0x1820D0EE0")]
		public bool IsInRange(Vector2 pos, out int forceIndex, out int pointIndex)
		{
			return default(bool);
		}

		// Token: 0x06025E74 RID: 155252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E74")]
		[Address(RVA = "0x20D1300", Offset = "0x20CFF00", VA = "0x1820D1300")]
		public void RemovePoint(int pointIndex)
		{
		}

		// Token: 0x06025E75 RID: 155253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E75")]
		[Address(RVA = "0x20D0EA0", Offset = "0x20CFAA0", VA = "0x1820D0EA0")]
		public void AddPoint(Vector2 position)
		{
		}

		// Token: 0x06025E76 RID: 155254 RVA: 0x000C9618 File Offset: 0x000C7818
		[Token(Token = "0x6025E76")]
		[Address(RVA = "0x20D0EC0", Offset = "0x20CFAC0", VA = "0x1820D0EC0")]
		public bool IsAdjacent(Vector2 localPosition, out Vector2 precisePos)
		{
			return default(bool);
		}

		// Token: 0x06025E77 RID: 155255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E77")]
		[Address(RVA = "0x20D1660", Offset = "0x20D0260", VA = "0x1820D1660")]
		public void SavePointList(List<HandBookV2PointData> pointList)
		{
		}

		// Token: 0x170059C7 RID: 22983
		// (get) Token: 0x06025E78 RID: 155256 RVA: 0x000C9630 File Offset: 0x000C7830
		// (set) Token: 0x06025E79 RID: 155257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059C7")]
		public Vector2 bgPos
		{
			[Token(Token = "0x6025E78")]
			[Address(RVA = "0x20D0370", Offset = "0x20CEF70", VA = "0x1820D0370")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6025E79")]
			[Address(RVA = "0x20D03D0", Offset = "0x20CEFD0", VA = "0x1820D03D0")]
			set
			{
			}
		}

		// Token: 0x170059C8 RID: 22984
		// (get) Token: 0x06025E7A RID: 155258 RVA: 0x000C9648 File Offset: 0x000C7848
		// (set) Token: 0x06025E7B RID: 155259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059C8")]
		public Vector2 logoPos
		{
			[Token(Token = "0x6025E7A")]
			[Address(RVA = "0x20D1AD0", Offset = "0x20D06D0", VA = "0x1820D1AD0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6025E7B")]
			[Address(RVA = "0x20D1B40", Offset = "0x20D0740", VA = "0x1820D1B40")]
			set
			{
			}
		}

		// Token: 0x170059C9 RID: 22985
		// (get) Token: 0x06025E7C RID: 155260 RVA: 0x000C9660 File Offset: 0x000C7860
		// (set) Token: 0x06025E7D RID: 155261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170059C9")]
		public float logoScale
		{
			[Token(Token = "0x6025E7C")]
			[Address(RVA = "0x20D1B00", Offset = "0x20D0700", VA = "0x1820D1B00")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6025E7D")]
			[Address(RVA = "0x20D1B80", Offset = "0x20D0780", VA = "0x1820D1B80")]
			set
			{
			}
		}

		// Token: 0x06025E7E RID: 155262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E7E")]
		[Address(RVA = "0x20D0F10", Offset = "0x20CFB10", VA = "0x1820D0F10")]
		public void OnBeginMove()
		{
		}

		// Token: 0x06025E7F RID: 155263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E7F")]
		[Address(RVA = "0x20D1190", Offset = "0x20CFD90", VA = "0x1820D1190")]
		public void OnMove(Vector2 delta)
		{
		}

		// Token: 0x06025E80 RID: 155264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E80")]
		[Address(RVA = "0x20D1030", Offset = "0x20CFC30", VA = "0x1820D1030")]
		public void OnClick()
		{
		}

		// Token: 0x06025E81 RID: 155265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E81")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookV2EditorForceView()
		{
		}

		// Token: 0x040354D7 RID: 218327
		[Token(Token = "0x40354D7")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2EditorForceBgView _bgView;

		// Token: 0x040354D8 RID: 218328
		[Token(Token = "0x40354D8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private HandBookV2EditorForceLogoView _logoView;

		// Token: 0x040354DA RID: 218330
		[Token(Token = "0x40354DA")]
		[FieldOffset(Offset = "0x30")]
		private Vector2 m_startPos;
	}
}
