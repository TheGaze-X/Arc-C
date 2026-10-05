using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI
{
	// Token: 0x02001B16 RID: 6934
	[Token(Token = "0x2001B16")]
	public class BuildingCharMPStateBar : MonoBehaviour
	{
		// Token: 0x0600AEB4 RID: 44724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB4")]
		[Address(RVA = "0x328EB80", Offset = "0x328D780", VA = "0x18328EB80")]
		public void Render(BuildingCharMPStateBar.Model model)
		{
		}

		// Token: 0x0600AEB5 RID: 44725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AEB5")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public BuildingCharMPStateBar()
		{
		}

		// Token: 0x0400A7AA RID: 42922
		[Token(Token = "0x400A7AA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private StretchProgressBar _progress;

		// Token: 0x0400A7AB RID: 42923
		[Token(Token = "0x400A7AB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _hilightEmpty;

		// Token: 0x0400A7AC RID: 42924
		[Token(Token = "0x400A7AC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _iconState;

		// Token: 0x0400A7AD RID: 42925
		[Token(Token = "0x400A7AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuildingCharMPStateBar.IconConfig[] _iconConfig;

		// Token: 0x0400A7AE RID: 42926
		[Token(Token = "0x400A7AE")]
		[FieldOffset(Offset = "0x38")]
		private BuildingCharMPStateBar.Model m_cachedModel;

		// Token: 0x0400A7AF RID: 42927
		[Token(Token = "0x400A7AF")]
		[FieldOffset(Offset = "0x50")]
		private bool m_isInited;

		// Token: 0x02001B17 RID: 6935
		[Token(Token = "0x2001B17")]
		public struct Model
		{
			// Token: 0x0400A7B0 RID: 42928
			[Token(Token = "0x400A7B0")]
			[FieldOffset(Offset = "0x0")]
			public CharManpowerState state;

			// Token: 0x0400A7B1 RID: 42929
			[Token(Token = "0x400A7B1")]
			[FieldOffset(Offset = "0x8")]
			public long curAp;

			// Token: 0x0400A7B2 RID: 42930
			[Token(Token = "0x400A7B2")]
			[FieldOffset(Offset = "0x10")]
			public long maxAp;
		}

		// Token: 0x02001B18 RID: 6936
		[Token(Token = "0x2001B18")]
		[Serializable]
		public struct IconConfig
		{
			// Token: 0x0400A7B3 RID: 42931
			[Token(Token = "0x400A7B3")]
			[FieldOffset(Offset = "0x0")]
			public CharManpowerState state;

			// Token: 0x0400A7B4 RID: 42932
			[Token(Token = "0x400A7B4")]
			[FieldOffset(Offset = "0x8")]
			public Sprite icon;
		}
	}
}
