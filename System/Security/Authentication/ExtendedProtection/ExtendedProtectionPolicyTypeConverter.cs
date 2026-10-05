using System;
using System.ComponentModel;
using System.Globalization;
using Il2CppDummyDll;

namespace System.Security.Authentication.ExtendedProtection
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	[MonoTODO]
	public class ExtendedProtectionPolicyTypeConverter : TypeConverter
	{
		// Token: 0x06000702 RID: 1794 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x5107BA0", Offset = "0x51067A0", VA = "0x185107BA0", Slot = "5")]
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return default(bool);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x5107BF0", Offset = "0x51067F0", VA = "0x185107BF0", Slot = "7")]
		public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
		{
			return null;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		public ExtendedProtectionPolicyTypeConverter()
		{
		}
	}
}
