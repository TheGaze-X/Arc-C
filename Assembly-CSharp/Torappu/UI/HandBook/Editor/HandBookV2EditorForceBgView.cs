using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.HandBook.Editor
{
	// Token: 0x02006736 RID: 26422
	[Token(Token = "0x2006736")]
	public class HandBookV2EditorForceBgView : MonoBehaviour
	{
		// Token: 0x170059BE RID: 22974
		// (get) Token: 0x06025E34 RID: 155188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170059BE")]
		public string editColor
		{
			[Token(Token = "0x6025E34")]
			[Address(RVA = "0x20CF5E0", Offset = "0x20CE1E0", VA = "0x1820CF5E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025E35 RID: 155189 RVA: 0x000C9540 File Offset: 0x000C7740
		[Token(Token = "0x6025E35")]
		[Address(RVA = "0x20CE110", Offset = "0x20CCD10", VA = "0x1820CE110")]
		private int GetMaxPointIndex()
		{
			return 0;
		}

		// Token: 0x170059BF RID: 22975
		// (get) Token: 0x06025E36 RID: 155190 RVA: 0x000C9558 File Offset: 0x000C7758
		[Token(Token = "0x170059BF")]
		public int currentPointCount
		{
			[Token(Token = "0x6025E36")]
			[Address(RVA = "0x20CF590", Offset = "0x20CE190", VA = "0x1820CF590")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06025E37 RID: 155191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E37")]
		[Address(RVA = "0x20CEFB0", Offset = "0x20CDBB0", VA = "0x1820CEFB0")]
		public void SetRaycast(bool canRaycast)
		{
		}

		// Token: 0x06025E38 RID: 155192 RVA: 0x000C9570 File Offset: 0x000C7770
		[Token(Token = "0x6025E38")]
		[Address(RVA = "0x20CE480", Offset = "0x20CD080", VA = "0x1820CE480")]
		public bool IsInRange(Vector2 pos, out int forceIndex, out int pointIndex)
		{
			return default(bool);
		}

		// Token: 0x06025E39 RID: 155193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E39")]
		[Address(RVA = "0x20CF210", Offset = "0x20CDE10", VA = "0x1820CF210")]
		public void UpdateColor(Color? color)
		{
		}

		// Token: 0x06025E3A RID: 155194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E3A")]
		[Address(RVA = "0x20CF230", Offset = "0x20CDE30", VA = "0x1820CF230")]
		private void _ClearColor()
		{
		}

		// Token: 0x06025E3B RID: 155195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E3B")]
		[Address(RVA = "0x20CF2F0", Offset = "0x20CDEF0", VA = "0x1820CF2F0")]
		private void _UpdateColor()
		{
		}

		// Token: 0x06025E3C RID: 155196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E3C")]
		[Address(RVA = "0x20CE750", Offset = "0x20CD350", VA = "0x1820CE750")]
		public void Render(HandBookV2ForceData forceData)
		{
		}

		// Token: 0x06025E3D RID: 155197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E3D")]
		[Address(RVA = "0x20CEA60", Offset = "0x20CD660", VA = "0x1820CEA60")]
		public void SavePointList(List<HandBookV2PointData> pointList)
		{
		}

		// Token: 0x06025E3E RID: 155198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E3E")]
		[Address(RVA = "0x20CEFD0", Offset = "0x20CDBD0", VA = "0x1820CEFD0")]
		public void ToggleBgStyle(bool isSolid)
		{
		}

		// Token: 0x06025E3F RID: 155199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E3F")]
		[Address(RVA = "0x20CF160", Offset = "0x20CDD60", VA = "0x1820CF160")]
		public void TogglePointBgStyle(int pointIndex, bool isSolid)
		{
		}

		// Token: 0x06025E40 RID: 155200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E40")]
		[Address(RVA = "0x20CE690", Offset = "0x20CD290", VA = "0x1820CE690")]
		public void RemovePoint(int pointIndex)
		{
		}

		// Token: 0x06025E41 RID: 155201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E41")]
		[Address(RVA = "0x20CDEE0", Offset = "0x20CCAE0", VA = "0x1820CDEE0")]
		public void AddPoint(Vector2 position)
		{
		}

		// Token: 0x06025E42 RID: 155202 RVA: 0x000C9588 File Offset: 0x000C7788
		[Token(Token = "0x6025E42")]
		[Address(RVA = "0x20CE250", Offset = "0x20CCE50", VA = "0x1820CE250")]
		public bool IsAdjacent(Vector2 roughPos, out Vector2 precisePos)
		{
			return default(bool);
		}

		// Token: 0x06025E43 RID: 155203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025E43")]
		[Address(RVA = "0x20CF500", Offset = "0x20CE100", VA = "0x1820CF500")]
		public HandBookV2EditorForceBgView()
		{
		}

		// Token: 0x040354B9 RID: 218297
		[Token(Token = "0x40354B9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private HandBookV2EditorForcePointView _pointTemplate;

		// Token: 0x040354BA RID: 218298
		[Token(Token = "0x40354BA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x040354BB RID: 218299
		[Token(Token = "0x40354BB")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, HandBookV2EditorForcePointView> m_pointViewMap;

		// Token: 0x040354BC RID: 218300
		[Token(Token = "0x40354BC")]
		[FieldOffset(Offset = "0x30")]
		private HandBookV2ForceData m_forceData;

		// Token: 0x040354BD RID: 218301
		[Token(Token = "0x40354BD")]
		[FieldOffset(Offset = "0x38")]
		private Color? m_editColor;
	}
}
