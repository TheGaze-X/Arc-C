using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x020000A9 RID: 169
	[Token(Token = "0x20000A9")]
	public class AndroidCPUInfoReader : Singleton<AndroidCPUInfoReader>
	{
		// Token: 0x0600042A RID: 1066 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x54FA510", Offset = "0x54F9110", VA = "0x1854FA510")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x54FA430", Offset = "0x54F9030", VA = "0x1854FA430")]
		public List<string> GetHardwareCandidates()
		{
			return null;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x54FA4A0", Offset = "0x54F90A0", VA = "0x1854FA4A0")]
		public string GetModelName()
		{
			return null;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x54FA650", Offset = "0x54F9250", VA = "0x1854FA650")]
		private void _OnReadCPUInfoLine(string line)
		{
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x54FAB00", Offset = "0x54F9700", VA = "0x1854FAB00")]
		private static string _ReadLineContent(string line)
		{
			return null;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x600042F")]
		[Address(RVA = "0x54FA7D0", Offset = "0x54F93D0", VA = "0x1854FA7D0")]
		private static void _ReadCPUInfoFileWithRetry(Action<string> onReadLine)
		{
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x54FAAA0", Offset = "0x54F96A0", VA = "0x1854FAAA0")]
		private void _ReadHardwareProperty()
		{
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x54FABD0", Offset = "0x54F97D0", VA = "0x1854FABD0")]
		private AndroidCPUInfoReader()
		{
		}

		// Token: 0x04000443 RID: 1091
		[Token(Token = "0x4000443")]
		private const string CPU_INFO_PATH = "/proc/cpuinfo";

		// Token: 0x04000444 RID: 1092
		[Token(Token = "0x4000444")]
		private const string KEY_HARDWARD = "hardware";

		// Token: 0x04000445 RID: 1093
		[Token(Token = "0x4000445")]
		private const string KEY_MODENAME = "model name";

		// Token: 0x04000446 RID: 1094
		[Token(Token = "0x4000446")]
		private const string KEY_SYSTEMINFO_HARDWARE = "ro.hardware";

		// Token: 0x04000447 RID: 1095
		[Token(Token = "0x4000447")]
		private const int IO_RETRY_COUNT = 3;

		// Token: 0x04000448 RID: 1096
		[Token(Token = "0x4000448")]
		[FieldOffset(Offset = "0x10")]
		private List<string> m_hardwares;

		// Token: 0x04000449 RID: 1097
		[Token(Token = "0x4000449")]
		[FieldOffset(Offset = "0x18")]
		private string m_modelName;

		// Token: 0x0400044A RID: 1098
		[Token(Token = "0x400044A")]
		[FieldOffset(Offset = "0x20")]
		private bool m_isInited;

		// Token: 0x0400044B RID: 1099
		[Token(Token = "0x400044B")]
		[FieldOffset(Offset = "0x0")]
		private static __XLua_Gen_Delegate1 __Hotfix0__InitIfNot;

		// Token: 0x0400044C RID: 1100
		[Token(Token = "0x400044C")]
		[FieldOffset(Offset = "0x8")]
		private static __XLua_Gen_Delegate53 __Hotfix0_GetHardwareCandidates;

		// Token: 0x0400044D RID: 1101
		[Token(Token = "0x400044D")]
		[FieldOffset(Offset = "0x10")]
		private static __XLua_Gen_Delegate19 __Hotfix0_GetModelName;

		// Token: 0x0400044E RID: 1102
		[Token(Token = "0x400044E")]
		[FieldOffset(Offset = "0x18")]
		private static __XLua_Gen_Delegate0 __Hotfix0__OnReadCPUInfoLine;

		// Token: 0x0400044F RID: 1103
		[Token(Token = "0x400044F")]
		[FieldOffset(Offset = "0x20")]
		private static __XLua_Gen_Delegate19 __Hotfix0__ReadLineContent;

		// Token: 0x04000450 RID: 1104
		[Token(Token = "0x4000450")]
		[FieldOffset(Offset = "0x28")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ReadCPUInfoFileWithRetry;

		// Token: 0x04000451 RID: 1105
		[Token(Token = "0x4000451")]
		[FieldOffset(Offset = "0x30")]
		private static __XLua_Gen_Delegate1 __Hotfix0__ReadHardwareProperty;

		// Token: 0x04000452 RID: 1106
		[Token(Token = "0x4000452")]
		[FieldOffset(Offset = "0x38")]
		private static __XLua_Gen_Delegate1 _c__Hotfix0_ctor;
	}
}
