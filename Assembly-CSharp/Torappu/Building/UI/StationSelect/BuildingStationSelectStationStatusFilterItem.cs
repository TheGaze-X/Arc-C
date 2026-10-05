using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C97 RID: 7319
	[Token(Token = "0x2001C97")]
	public class BuildingStationSelectStationStatusFilterItem : BuildingUINotFlagFilterItem<BuildingData.CharStationFilterType>
	{
		// Token: 0x0600B5A2 RID: 46498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5A2")]
		[Address(RVA = "0x3312B50", Offset = "0x3311750", VA = "0x183312B50", Slot = "4")]
		public override void Render(BuildingData.CharStationFilterType filterEnum)
		{
		}

		// Token: 0x0600B5A3 RID: 46499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B5A3")]
		[Address(RVA = "0x3312CA0", Offset = "0x33118A0", VA = "0x183312CA0")]
		public BuildingStationSelectStationStatusFilterItem()
		{
		}

		// Token: 0x0400B233 RID: 45619
		[Token(Token = "0x400B233")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textStatusUnSelectName;

		// Token: 0x0400B234 RID: 45620
		[Token(Token = "0x400B234")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textStatusSelectName;
	}
}
