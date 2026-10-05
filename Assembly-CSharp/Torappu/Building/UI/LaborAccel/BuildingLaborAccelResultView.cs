using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.LaborAccel
{
	// Token: 0x02001DBA RID: 7610
	[Token(Token = "0x2001DBA")]
	public class BuildingLaborAccelResultView : DataBinder<BuildingLaborAccelState.AccelResultProperty>
	{
		// Token: 0x0600BBA7 RID: 48039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBA7")]
		[Address(RVA = "0x338F390", Offset = "0x338DF90", VA = "0x18338F390", Slot = "7")]
		public override void OnValueChanged(BuildingLaborAccelState.AccelResultProperty property)
		{
		}

		// Token: 0x0600BBA8 RID: 48040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BBA8")]
		[Address(RVA = "0x338F530", Offset = "0x338E130", VA = "0x18338F530")]
		public BuildingLaborAccelResultView()
		{
		}

		// Token: 0x0400BB7B RID: 47995
		[Token(Token = "0x400BB7B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400BB7C RID: 47996
		[Token(Token = "0x400BB7C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textUnit;

		// Token: 0x0400BB7D RID: 47997
		[Token(Token = "0x400BB7D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400BB7E RID: 47998
		[Token(Token = "0x400BB7E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _timeDescWithResult;

		// Token: 0x0400BB7F RID: 47999
		[Token(Token = "0x400BB7F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _timeDescWithoutResult;

		// Token: 0x0400BB80 RID: 48000
		[Token(Token = "0x400BB80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BB81 RID: 48001
		[Token(Token = "0x400BB81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
