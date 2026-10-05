using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using Il2CppDummyDll;

namespace System.Diagnostics
{
	// Token: 0x02000113 RID: 275
	[Token(Token = "0x2000113")]
	[TypeConverter(typeof(ExpandableObjectConverter))]
	[StructLayout(0)]
	public sealed class ProcessStartInfo
	{
		// Token: 0x060006C6 RID: 1734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60006C6")]
		[Address(RVA = "0x5107DC0", Offset = "0x51069C0", VA = "0x185107DC0")]
		internal ProcessStartInfo(Process parent)
		{
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060006C7 RID: 1735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000123")]
		public Collection<string> ArgumentList
		{
			[Token(Token = "0x60006C7")]
			[Address(RVA = "0x5107E50", Offset = "0x5106A50", VA = "0x185107E50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000124")]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[SettingsBindable(true)]
		[DefaultValue("")]
		[MonitoringDescription("Command line arguments that will be passed to the application specified by the FileName property.")]
		[NotifyParentProperty(true)]
		public string Arguments
		{
			[Token(Token = "0x60006C8")]
			[Address(RVA = "0x5107EF0", Offset = "0x5106AF0", VA = "0x185107EF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006C9")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
			set
			{
			}
		}

		// Token: 0x17000125 RID: 293
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000125")]
		[DefaultValue(false)]
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether to start the process without creating a new window to contain it.")]
		public bool CreateNoWindow
		{
			[Token(Token = "0x60006CA")]
			[Address(RVA = "0x332AEF0", Offset = "0x3329AF0", VA = "0x18332AEF0")]
			set
			{
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060006CB RID: 1739 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000126")]
		[Editor("System.Diagnostics.Design.StringDictionaryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DefaultValue(null)]
		[MonitoringDescription("Set of environment variables that apply to this process and child processes.")]
		[NotifyParentProperty(true)]
		public StringDictionary EnvironmentVariables
		{
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x5107F90", Offset = "0x5106B90", VA = "0x185107F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x17000127")]
		[MonitoringDescription("Whether the process command input is read from the Process instance's StandardInput member.")]
		[DefaultValue(false)]
		[NotifyParentProperty(true)]
		public bool RedirectStandardInput
		{
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0xE31BA0", Offset = "0xE307A0", VA = "0x180E31BA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060006CD RID: 1741 RVA: 0x00004B90 File Offset: 0x00002D90
		// (set) Token: 0x060006CE RID: 1742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000128")]
		[MonitoringDescription("Whether the process output is written to the Process instance's StandardOutput member.")]
		[NotifyParentProperty(true)]
		[DefaultValue(false)]
		public bool RedirectStandardOutput
		{
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0xE31BC0", Offset = "0xE307C0", VA = "0x180E31BC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x5108520", Offset = "0x5107120", VA = "0x185108520")]
			set
			{
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x00004BA8 File Offset: 0x00002DA8
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000129")]
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether the process's error output is written to the Process instance's StandardError member.")]
		[DefaultValue(false)]
		public bool RedirectStandardError
		{
			[Token(Token = "0x60006CF")]
			[Address(RVA = "0x4E18D20", Offset = "0x4E17920", VA = "0x184E18D20")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x5108510", Offset = "0x5107110", VA = "0x185108510")]
			set
			{
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012A")]
		public Encoding StandardErrorEncoding
		{
			[Token(Token = "0x60006D1")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012B")]
		public Encoding StandardOutputEncoding
		{
			[Token(Token = "0x60006D2")]
			[Address(RVA = "0xEB4B70", Offset = "0xEB3770", VA = "0x180EB4B70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x00004BC0 File Offset: 0x00002DC0
		// (set) Token: 0x060006D4 RID: 1748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700012C")]
		[NotifyParentProperty(true)]
		[MonitoringDescription("Whether to use the operating system shell to start the process.")]
		[DefaultValue(true)]
		public bool UseShellExecute
		{
			[Token(Token = "0x60006D3")]
			[Address(RVA = "0xD36A60", Offset = "0xD35660", VA = "0x180D36A60")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60006D4")]
			[Address(RVA = "0x2860DE0", Offset = "0x285F9E0", VA = "0x182860DE0")]
			set
			{
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012D")]
		[NotifyParentProperty(true)]
		public string UserName
		{
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x5108470", Offset = "0x5107070", VA = "0x185108470")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012E")]
		public SecureString Password
		{
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x5EC4B0", Offset = "0x5EB0B0", VA = "0x1805EC4B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700012F")]
		[NotifyParentProperty(true)]
		public string Domain
		{
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x5107F40", Offset = "0x5106B40", VA = "0x185107F40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060006D8 RID: 1752 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x17000130")]
		[NotifyParentProperty(true)]
		public bool LoadUserProfile
		{
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0xE31BB0", Offset = "0xE307B0", VA = "0x180E31BB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000131")]
		[Editor("System.Diagnostics.Design.StartFileNameEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[MonitoringDescription("The name of the application, document or URL to start.")]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[NotifyParentProperty(true)]
		[DefaultValue("")]
		[SettingsBindable(true)]
		public string FileName
		{
			[Token(Token = "0x60006D9")]
			[Address(RVA = "0x5108410", Offset = "0x5107010", VA = "0x185108410")]
			get
			{
				return null;
			}
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			set
			{
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000132")]
		[MonitoringDescription("The initial working directory for the process.")]
		[NotifyParentProperty(true)]
		[Editor("System.Diagnostics.Design.WorkingDirectoryEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor, System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		[SettingsBindable(true)]
		[DefaultValue("")]
		[TypeConverter("System.Diagnostics.Design.StringValueConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
		public string WorkingDirectory
		{
			[Token(Token = "0x60006DB")]
			[Address(RVA = "0x51084C0", Offset = "0x51070C0", VA = "0x1851084C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x17000133")]
		internal bool HaveEnvVars
		{
			[Token(Token = "0x60006DC")]
			[Address(RVA = "0x5108460", Offset = "0x5107060", VA = "0x185108460")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000134")]
		public Encoding StandardInputEncoding
		{
			[Token(Token = "0x60006DD")]
			[Address(RVA = "0x4E8B00", Offset = "0x4E7700", VA = "0x1804E8B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x040004C3 RID: 1219
		[Token(Token = "0x40004C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private string fileName;

		// Token: 0x040004C4 RID: 1220
		[Token(Token = "0x40004C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private string arguments;

		// Token: 0x040004C5 RID: 1221
		[Token(Token = "0x40004C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private string directory;

		// Token: 0x040004C6 RID: 1222
		[Token(Token = "0x40004C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private string verb;

		// Token: 0x040004C7 RID: 1223
		[Token(Token = "0x40004C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private ProcessWindowStyle windowStyle;

		// Token: 0x040004C8 RID: 1224
		[Token(Token = "0x40004C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private bool errorDialog;

		// Token: 0x040004C9 RID: 1225
		[Token(Token = "0x40004C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private IntPtr errorDialogParentHandle;

		// Token: 0x040004CA RID: 1226
		[Token(Token = "0x40004CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool useShellExecute;

		// Token: 0x040004CB RID: 1227
		[Token(Token = "0x40004CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private string userName;

		// Token: 0x040004CC RID: 1228
		[Token(Token = "0x40004CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private string domain;

		// Token: 0x040004CD RID: 1229
		[Token(Token = "0x40004CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private SecureString password;

		// Token: 0x040004CE RID: 1230
		[Token(Token = "0x40004CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private string passwordInClearText;

		// Token: 0x040004CF RID: 1231
		[Token(Token = "0x40004CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private bool loadUserProfile;

		// Token: 0x040004D0 RID: 1232
		[Token(Token = "0x40004D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x69")]
		private bool redirectStandardInput;

		// Token: 0x040004D1 RID: 1233
		[Token(Token = "0x40004D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A")]
		private bool redirectStandardOutput;

		// Token: 0x040004D2 RID: 1234
		[Token(Token = "0x40004D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B")]
		private bool redirectStandardError;

		// Token: 0x040004D3 RID: 1235
		[Token(Token = "0x40004D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private Encoding standardOutputEncoding;

		// Token: 0x040004D4 RID: 1236
		[Token(Token = "0x40004D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private Encoding standardErrorEncoding;

		// Token: 0x040004D5 RID: 1237
		[Token(Token = "0x40004D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool createNoWindow;

		// Token: 0x040004D6 RID: 1238
		[Token(Token = "0x40004D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private WeakReference weakParentProcess;

		// Token: 0x040004D7 RID: 1239
		[Token(Token = "0x40004D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		internal StringDictionary environmentVariables;

		// Token: 0x040004D8 RID: 1240
		[Token(Token = "0x40004D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly string[] empty;

		// Token: 0x040004D9 RID: 1241
		[Token(Token = "0x40004D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private Collection<string> _argumentList;

		// Token: 0x040004DA RID: 1242
		[Token(Token = "0x40004DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private IDictionary<string, string> environment;
	}
}
