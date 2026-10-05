using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.HandBook
{
	// Token: 0x020066A7 RID: 26279
	[Token(Token = "0x20066A7")]
	[RequireComponent(typeof(Animator), typeof(CanvasGroup))]
	public class HandBookTeamView : MonoBehaviour
	{
		// Token: 0x17005968 RID: 22888
		// (get) Token: 0x06025BEE RID: 154606 RVA: 0x000C8DD8 File Offset: 0x000C6FD8
		// (set) Token: 0x06025BEF RID: 154607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005968")]
		public Vector3 initPos
		{
			[Token(Token = "0x6025BEE")]
			[Address(RVA = "0x20B27C0", Offset = "0x20B13C0", VA = "0x1820B27C0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6025BEF")]
			[Address(RVA = "0x20B2810", Offset = "0x20B1410", VA = "0x1820B2810")]
			set
			{
			}
		}

		// Token: 0x17005969 RID: 22889
		// (get) Token: 0x06025BF0 RID: 154608 RVA: 0x000C8DF0 File Offset: 0x000C6FF0
		// (set) Token: 0x06025BF1 RID: 154609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005969")]
		public Vector3 initDest
		{
			[Token(Token = "0x6025BF0")]
			[Address(RVA = "0x20B27A0", Offset = "0x20B13A0", VA = "0x1820B27A0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6025BF1")]
			[Address(RVA = "0x20B2800", Offset = "0x20B1400", VA = "0x1820B2800")]
			set
			{
			}
		}

		// Token: 0x1700596A RID: 22890
		// (get) Token: 0x06025BF3 RID: 154611 RVA: 0x000C8E08 File Offset: 0x000C7008
		// (set) Token: 0x06025BF2 RID: 154610 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700596A")]
		public Vector3 largeImageInitPos
		{
			[Token(Token = "0x6025BF3")]
			[Address(RVA = "0x20B27E0", Offset = "0x20B13E0", VA = "0x1820B27E0")]
			private get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6025BF2")]
			[Address(RVA = "0x20B2820", Offset = "0x20B1420", VA = "0x1820B2820")]
			set
			{
			}
		}

		// Token: 0x1700596B RID: 22891
		// (get) Token: 0x06025BF5 RID: 154613 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06025BF4 RID: 154612 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700596B")]
		public Transform largeImage
		{
			[Token(Token = "0x6025BF5")]
			[Address(RVA = "0x789270", Offset = "0x787E70", VA = "0x180789270")]
			private get
			{
				return null;
			}
			[Token(Token = "0x6025BF4")]
			[Address(RVA = "0x1FC11F0", Offset = "0x1FBFDF0", VA = "0x181FC11F0")]
			set
			{
			}
		}

		// Token: 0x06025BF6 RID: 154614 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BF6")]
		[Address(RVA = "0x20B1E50", Offset = "0x20B0A50", VA = "0x1820B1E50")]
		public void InitData(HandbookTeamData teamInfo, HandbookTeamIconData teamData, float teamPercent, int teamPoint, Sprite teamICON)
		{
		}

		// Token: 0x06025BF7 RID: 154615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BF7")]
		[Address(RVA = "0x20B26E0", Offset = "0x20B12E0", VA = "0x1820B26E0")]
		public void UnShow()
		{
		}

		// Token: 0x06025BF8 RID: 154616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BF8")]
		[Address(RVA = "0x20B2350", Offset = "0x20B0F50", VA = "0x1820B2350")]
		public void OnValueChanged(HandBookScrollViewProperty property)
		{
		}

		// Token: 0x06025BF9 RID: 154617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025BF9")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public HandBookTeamView()
		{
		}

		// Token: 0x040350DE RID: 217310
		[Token(Token = "0x40350DE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _teamName;

		// Token: 0x040350DF RID: 217311
		[Token(Token = "0x40350DF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _teamPercent;

		// Token: 0x040350E0 RID: 217312
		[Token(Token = "0x40350E0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _teamFavorPoint;

		// Token: 0x040350E1 RID: 217313
		[Token(Token = "0x40350E1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _teamBackground;

		// Token: 0x040350E2 RID: 217314
		[Token(Token = "0x40350E2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image[] _lines;

		// Token: 0x040350E3 RID: 217315
		[Token(Token = "0x40350E3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform[] _linePoints;

		// Token: 0x040350E4 RID: 217316
		[Token(Token = "0x40350E4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image[] _teamImage;

		// Token: 0x040350E5 RID: 217317
		[Token(Token = "0x40350E5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Animator _canvasControl;

		// Token: 0x040350E6 RID: 217318
		[Token(Token = "0x40350E6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private LineRenderer _linerender;

		// Token: 0x040350E7 RID: 217319
		[Token(Token = "0x40350E7")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 m_initPos;

		// Token: 0x040350E8 RID: 217320
		[Token(Token = "0x40350E8")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 m_initDest;

		// Token: 0x040350E9 RID: 217321
		[Token(Token = "0x40350E9")]
		[FieldOffset(Offset = "0x78")]
		private Image m_teamICON;

		// Token: 0x040350EA RID: 217322
		[Token(Token = "0x40350EA")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 m_largeImageDest;

		// Token: 0x040350EB RID: 217323
		[Token(Token = "0x40350EB")]
		[FieldOffset(Offset = "0x90")]
		private Transform m_largeImage;

		// Token: 0x040350EC RID: 217324
		[Token(Token = "0x40350EC")]
		[FieldOffset(Offset = "0x98")]
		private int teamType;
	}
}
