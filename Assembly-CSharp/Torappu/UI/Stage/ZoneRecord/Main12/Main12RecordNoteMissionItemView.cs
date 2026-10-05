using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Stage.ZoneRecord.Main12
{
	// Token: 0x02006A12 RID: 27154
	[Token(Token = "0x2006A12")]
	public class Main12RecordNoteMissionItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06026D22 RID: 159010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D22")]
		[Address(RVA = "0x21F6A10", Offset = "0x21F5610", VA = "0x1821F6A10")]
		public void Render(string desc)
		{
		}

		// Token: 0x06026D23 RID: 159011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026D23")]
		[Address(RVA = "0x21F6B20", Offset = "0x21F5720", VA = "0x1821F6B20")]
		public Main12RecordNoteMissionItemView()
		{
		}

		// Token: 0x04036DBA RID: 224698
		[Token(Token = "0x4036DBA")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _missionDesc;

		// Token: 0x04036DBB RID: 224699
		[Token(Token = "0x4036DBB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04036DBC RID: 224700
		[Token(Token = "0x4036DBC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
