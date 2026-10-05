using System;
using Hypergryph.Log;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu
{
	// Token: 0x020013DE RID: 5086
	[Token(Token = "0x20013DE")]
	[CreateAssetMenu(menuName = "Torappu/Options/DLogOptions")]
	public class DLogOptions : SingletonScriptableObject<DLogOptions>
	{
		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06007401 RID: 29697 RVA: 0x000338E8 File Offset: 0x00031AE8
		// (set) Token: 0x06007402 RID: 29698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E26")]
		public bool LogInfo
		{
			[Token(Token = "0x6007401")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007402")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06007403 RID: 29699 RVA: 0x00033900 File Offset: 0x00031B00
		// (set) Token: 0x06007404 RID: 29700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E27")]
		public bool LogWarnning
		{
			[Token(Token = "0x6007403")]
			[Address(RVA = "0x54A770", Offset = "0x549370", VA = "0x18054A770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007404")]
			[Address(RVA = "0x54A790", Offset = "0x549390", VA = "0x18054A790")]
			set
			{
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06007405 RID: 29701 RVA: 0x00033918 File Offset: 0x00031B18
		// (set) Token: 0x06007406 RID: 29702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E28")]
		public bool LogError
		{
			[Token(Token = "0x6007405")]
			[Address(RVA = "0x2205330", Offset = "0x2203F30", VA = "0x182205330")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007406")]
			[Address(RVA = "0x2205340", Offset = "0x2203F40", VA = "0x182205340")]
			set
			{
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06007407 RID: 29703 RVA: 0x00033930 File Offset: 0x00031B30
		// (set) Token: 0x06007408 RID: 29704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000E29")]
		public bool EnableAllForDevelopmentBuild
		{
			[Token(Token = "0x6007407")]
			[Address(RVA = "0x12411F0", Offset = "0x123FDF0", VA = "0x1812411F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6007408")]
			[Address(RVA = "0x1241210", Offset = "0x123FE10", VA = "0x181241210")]
			set
			{
			}
		}

		// Token: 0x06007409 RID: 29705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007409")]
		[Address(RVA = "0x2205270", Offset = "0x2203E70", VA = "0x182205270", Slot = "4")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600740A RID: 29706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740A")]
		[Address(RVA = "0x2205230", Offset = "0x2203E30", VA = "0x182205230", Slot = "5")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600740B RID: 29707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740B")]
		[Address(RVA = "0x2204F70", Offset = "0x2203B70", VA = "0x182204F70")]
		private void DoApply()
		{
		}

		// Token: 0x0600740C RID: 29708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740C")]
		[Address(RVA = "0x22052E0", Offset = "0x2203EE0", VA = "0x1822052E0")]
		public void RefreshSetting()
		{
		}

		// Token: 0x0600740D RID: 29709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740D")]
		[Address(RVA = "0x2205100", Offset = "0x2203D00", VA = "0x182205100")]
		private void EnableLogsWithOptions()
		{
		}

		// Token: 0x0600740E RID: 29710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600740E")]
		[Address(RVA = "0x2205070", Offset = "0x2203C70", VA = "0x182205070")]
		private void EnableAllLogs()
		{
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x00033948 File Offset: 0x00031B48
		[Token(Token = "0x600740F")]
		[Address(RVA = "0x22051C0", Offset = "0x2203DC0", VA = "0x1822051C0")]
		private LogLevel GetLogLevelFromOptions()
		{
			return (LogLevel)0;
		}

		// Token: 0x06007410 RID: 29712 RVA: 0x00033960 File Offset: 0x00031B60
		[Token(Token = "0x6007410")]
		[Address(RVA = "0x22051F0", Offset = "0x2203DF0", VA = "0x1822051F0")]
		private static bool IsDevelopmentBuild()
		{
			return default(bool);
		}

		// Token: 0x06007411 RID: 29713 RVA: 0x00033978 File Offset: 0x00031B78
		[Token(Token = "0x6007411")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40")]
		private static bool IsEditorMode()
		{
			return default(bool);
		}

		// Token: 0x06007412 RID: 29714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007412")]
		[Address(RVA = "0x22052F0", Offset = "0x2203EF0", VA = "0x1822052F0")]
		public DLogOptions()
		{
		}

		// Token: 0x040071B6 RID: 29110
		[Token(Token = "0x40071B6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private bool _logInfo;

		// Token: 0x040071B7 RID: 29111
		[Token(Token = "0x40071B7")]
		[FieldOffset(Offset = "0x19")]
		[SerializeField]
		private bool _logWarning;

		// Token: 0x040071B8 RID: 29112
		[Token(Token = "0x40071B8")]
		[FieldOffset(Offset = "0x1A")]
		[SerializeField]
		private bool _logError;

		// Token: 0x040071B9 RID: 29113
		[Token(Token = "0x40071B9")]
		[FieldOffset(Offset = "0x1B")]
		[SerializeField]
		private bool _enableAllForEditorMode;

		// Token: 0x040071BA RID: 29114
		[Token(Token = "0x40071BA")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool _enableAllForDevelopmentBuild;
	}
}
