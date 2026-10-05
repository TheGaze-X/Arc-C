using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.DB
{
	// Token: 0x020016A2 RID: 5794
	[Token(Token = "0x20016A2")]
	[Serializable]
	public class TableConfig
	{
		// Token: 0x17000F98 RID: 3992
		// (get) Token: 0x060092C2 RID: 37570 RVA: 0x00039198 File Offset: 0x00037398
		[Token(Token = "0x17000F98")]
		public bool fromResource
		{
			[Token(Token = "0x60092C2")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060092C3 RID: 37571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60092C3")]
		[Address(RVA = "0x1E9AB00", Offset = "0x1E99700", VA = "0x181E9AB00")]
		public TableConfig()
		{
		}

		// Token: 0x04008864 RID: 34916
		[Token(Token = "0x4008864")]
		[FieldOffset(Offset = "0x10")]
		public bool loadFromResource;

		// Token: 0x04008865 RID: 34917
		[Token(Token = "0x4008865")]
		[FieldOffset(Offset = "0x18")]
		[Inspect("fromResource")]
		public string assetPath;

		// Token: 0x04008866 RID: 34918
		[Token(Token = "0x4008866")]
		[FieldOffset(Offset = "0x20")]
		[Inspect("fromResource", false)]
		public TextAsset textAsset;

		// Token: 0x04008867 RID: 34919
		[Token(Token = "0x4008867")]
		[FieldOffset(Offset = "0x28")]
		public ConverterFactory.ConverterType convertType;
	}
}
