using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B63 RID: 7011
	[Token(Token = "0x2001B63")]
	public class UILevelInfoItemView : MonoBehaviour
	{
		// Token: 0x0600AFF2 RID: 45042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFF2")]
		[Address(RVA = "0x32B9FA0", Offset = "0x32B8BA0", VA = "0x1832B9FA0")]
		public void Setup(LevelInfoItem item)
		{
		}

		// Token: 0x0600AFF3 RID: 45043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AFF3")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UILevelInfoItemView()
		{
		}

		// Token: 0x0400AA39 RID: 43577
		[Token(Token = "0x400AA39")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _nameIcon;

		// Token: 0x0400AA3A RID: 43578
		[Token(Token = "0x400AA3A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemNameLabel;

		// Token: 0x0400AA3B RID: 43579
		[Token(Token = "0x400AA3B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _itemVal0Label;

		// Token: 0x0400AA3C RID: 43580
		[Token(Token = "0x400AA3C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _itemVal1Label;

		// Token: 0x0400AA3D RID: 43581
		[Token(Token = "0x400AA3D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _valRoot;

		// Token: 0x0400AA3E RID: 43582
		[Token(Token = "0x400AA3E")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _itemSingleLabel;

		// Token: 0x0400AA3F RID: 43583
		[Token(Token = "0x400AA3F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _ignoreConfigColor;

		// Token: 0x0400AA40 RID: 43584
		[Token(Token = "0x400AA40")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		public List<UILevelInfoItemView.LevelInfoTypeConfig> levelInfoTypeConfig;

		// Token: 0x02001B64 RID: 7012
		[Token(Token = "0x2001B64")]
		[Serializable]
		public class LevelInfoTypeConfig
		{
			// Token: 0x0600AFF4 RID: 45044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AFF4")]
			[Address(RVA = "0x32B0700", Offset = "0x32AF300", VA = "0x1832B0700")]
			public LevelInfoTypeConfig()
			{
			}

			// Token: 0x0400AA41 RID: 43585
			[Token(Token = "0x400AA41")]
			[FieldOffset(Offset = "0x10")]
			public LevelInfoType type;

			// Token: 0x0400AA42 RID: 43586
			[Token(Token = "0x400AA42")]
			[FieldOffset(Offset = "0x18")]
			public Sprite icon;

			// Token: 0x0400AA43 RID: 43587
			[Token(Token = "0x400AA43")]
			[FieldOffset(Offset = "0x20")]
			public bool single;

			// Token: 0x0400AA44 RID: 43588
			[Token(Token = "0x400AA44")]
			[FieldOffset(Offset = "0x24")]
			public Color color;
		}
	}
}
