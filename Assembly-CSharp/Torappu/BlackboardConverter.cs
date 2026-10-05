using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020013D9 RID: 5081
	[Token(Token = "0x20013D9")]
	public class BlackboardConverter : JsonConverter
	{
		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x060073EC RID: 29676 RVA: 0x00033870 File Offset: 0x00031A70
		[Token(Token = "0x17000E25")]
		public override bool CanRead
		{
			[Token(Token = "0x60073EC")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060073ED RID: 29677 RVA: 0x00033888 File Offset: 0x00031A88
		[Token(Token = "0x60073ED")]
		[Address(RVA = "0x21FEEE0", Offset = "0x21FDAE0", VA = "0x1821FEEE0", Slot = "6")]
		public override bool CanConvert(Type objectType)
		{
			return default(bool);
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073EE")]
		[Address(RVA = "0x21FEF80", Offset = "0x21FDB80", VA = "0x1821FEF80", Slot = "5")]
		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return null;
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073EF")]
		[Address(RVA = "0x21FEFE0", Offset = "0x21FDBE0", VA = "0x1821FEFE0", Slot = "4")]
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F0")]
		[Address(RVA = "0x21FF180", Offset = "0x21FDD80", VA = "0x1821FF180")]
		private void _WriteDataPair(JsonWriter writer, Blackboard.DataPair data)
		{
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60073F1")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public BlackboardConverter()
		{
		}
	}
}
