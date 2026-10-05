using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.Vault.UI
{
	// Token: 0x02001A89 RID: 6793
	[Token(Token = "0x2001A89")]
	public class VBuildingVisitorCard : VOUIPanel
	{
		// Token: 0x0600AB45 RID: 43845 RVA: 0x000423C0 File Offset: 0x000405C0
		[Token(Token = "0x600AB45")]
		[Address(RVA = "0x3253810", Offset = "0x3252410", VA = "0x183253810", Slot = "4")]
		public override bool MatchObject(BuildingEvent evt, VRoom.Object roomObject)
		{
			return default(bool);
		}

		// Token: 0x0600AB46 RID: 43846 RVA: 0x000423D8 File Offset: 0x000405D8
		[Token(Token = "0x600AB46")]
		[Address(RVA = "0x3253B20", Offset = "0x3252720", VA = "0x183253B20", Slot = "5")]
		protected override Vector3 PanelWorldCenter()
		{
			return default(Vector3);
		}

		// Token: 0x0600AB47 RID: 43847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB47")]
		[Address(RVA = "0x3253940", Offset = "0x3252540", VA = "0x183253940", Slot = "6")]
		protected override void OnRoomObjectBinded(VRoom.Object roomObj)
		{
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB48")]
		[Address(RVA = "0x3253C70", Offset = "0x3252870", VA = "0x183253C70", Slot = "9")]
		protected override void UpdateRender()
		{
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AB49")]
		[Address(RVA = "0x3253DC0", Offset = "0x32529C0", VA = "0x183253DC0")]
		public VBuildingVisitorCard()
		{
		}

		// Token: 0x0400A38F RID: 41871
		[Token(Token = "0x400A38F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400A390 RID: 41872
		[Token(Token = "0x400A390")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textLevel;

		// Token: 0x0400A391 RID: 41873
		[Token(Token = "0x400A391")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelCard;
	}
}
