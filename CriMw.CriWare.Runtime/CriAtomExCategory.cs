using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace CriWare
{
	// Token: 0x02000042 RID: 66
	[Token(Token = "0x2000042")]
	public static class CriAtomExCategory
	{
		// Token: 0x060001FB RID: 507 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x36C6AF0", Offset = "0x36C56F0", VA = "0x1836C6AF0")]
		public static void SetVolume(string name, float volume)
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x36C6A60", Offset = "0x36C5660", VA = "0x1836C6A60")]
		public static void SetVolume(int id, float volume)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x0000290C File Offset: 0x00000B0C
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x36C5DC0", Offset = "0x36C49C0", VA = "0x1836C5DC0")]
		public static float GetVolume(string name)
		{
			return 0f;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002924 File Offset: 0x00000B24
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x36C5E60", Offset = "0x36C4A60", VA = "0x1836C5E60")]
		public static float GetVolume(int id)
		{
			return 0f;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60001FF")]
		[Address(RVA = "0x36C6240", Offset = "0x36C4E40", VA = "0x1836C6240")]
		public static void Mute(string name, bool mute)
		{
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x36C62E0", Offset = "0x36C4EE0", VA = "0x1836C62E0")]
		public static void Mute(int id, bool mute)
		{
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000293C File Offset: 0x00000B3C
		[Token(Token = "0x6000201")]
		[Address(RVA = "0x36C5F60", Offset = "0x36C4B60", VA = "0x1836C5F60")]
		public static bool IsMuted(string name)
		{
			return default(bool);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00002954 File Offset: 0x00000B54
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x36C5EE0", Offset = "0x36C4AE0", VA = "0x1836C5EE0")]
		public static bool IsMuted(int id)
		{
			return default(bool);
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000203")]
		[Address(RVA = "0x36C6C30", Offset = "0x36C5830", VA = "0x1836C6C30")]
		public static void Solo(string name, bool solo, float muteVolume)
		{
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000204")]
		[Address(RVA = "0x36C6B90", Offset = "0x36C5790", VA = "0x1836C6B90")]
		public static void Solo(int id, bool solo, float muteVolume)
		{
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000296C File Offset: 0x00000B6C
		[Token(Token = "0x6000205")]
		[Address(RVA = "0x36C61A0", Offset = "0x36C4DA0", VA = "0x1836C61A0")]
		public static bool IsSoloed(string name)
		{
			return default(bool);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00002984 File Offset: 0x00000B84
		[Token(Token = "0x6000206")]
		[Address(RVA = "0x36C6120", Offset = "0x36C4D20", VA = "0x1836C6120")]
		public static bool IsSoloed(int id)
		{
			return default(bool);
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000207")]
		[Address(RVA = "0x36C6370", Offset = "0x36C4F70", VA = "0x1836C6370")]
		public static void Pause(string name, bool pause)
		{
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000208")]
		[Address(RVA = "0x36C6410", Offset = "0x36C5010", VA = "0x1836C6410")]
		public static void Pause(int id, bool pause)
		{
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000299C File Offset: 0x00000B9C
		[Token(Token = "0x6000209")]
		[Address(RVA = "0x36C6000", Offset = "0x36C4C00", VA = "0x1836C6000")]
		public static bool IsPaused(string name)
		{
			return default(bool);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x000029B4 File Offset: 0x00000BB4
		[Token(Token = "0x600020A")]
		[Address(RVA = "0x36C60A0", Offset = "0x36C4CA0", VA = "0x1836C60A0")]
		public static bool IsPaused(int id)
		{
			return default(bool);
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020B")]
		[Address(RVA = "0x36C6660", Offset = "0x36C5260", VA = "0x1836C6660")]
		public static void SetAisacControl(string name, string controlName, float value)
		{
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020C")]
		[Address(RVA = "0x36C6660", Offset = "0x36C5260", VA = "0x1836C6660")]
		[Obsolete("Use CriAtomExCategory.SetAisacControl")]
		public static void SetAisac(string name, string controlName, float value)
		{
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020D")]
		[Address(RVA = "0x36C65C0", Offset = "0x36C51C0", VA = "0x1836C65C0")]
		public static void SetAisacControl(int id, int controlId, float value)
		{
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020E")]
		[Address(RVA = "0x36C65C0", Offset = "0x36C51C0", VA = "0x1836C65C0")]
		[Obsolete("Use CriAtomExCategory.SetAisacControl")]
		public static void SetAisac(int id, int controlId, float value)
		{
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600020F")]
		[Address(RVA = "0x36C6980", Offset = "0x36C5580", VA = "0x1836C6980")]
		public static void SetReactParameter(string name, CriAtomExCategory.ReactParameter parameter)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x6000210")]
		[Address(RVA = "0x36C5AE0", Offset = "0x36C46E0", VA = "0x1836C5AE0")]
		public static bool GetReactParameter(string name, out CriAtomExCategory.ReactParameter parameter)
		{
			return default(bool);
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x6000211")]
		[Address(RVA = "0x36C5370", Offset = "0x36C3F70", VA = "0x1836C5370")]
		public static bool GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
		{
			return default(bool);
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x6000212")]
		[Address(RVA = "0x36C5590", Offset = "0x36C4190", VA = "0x1836C5590")]
		public static bool GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, out CriAtomEx.AisacInfo aisacInfo)
		{
			return default(bool);
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00002A14 File Offset: 0x00000C14
		[Token(Token = "0x6000213")]
		[Address(RVA = "0x36C57D0", Offset = "0x36C43D0", VA = "0x1836C57D0")]
		public static bool GetCurrentAisacControlValue(string categoryName, string aisacControlName, out float controlValue)
		{
			return default(bool);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x6000214")]
		[Address(RVA = "0x36C5C00", Offset = "0x36C4800", VA = "0x1836C5C00")]
		public static CriAtomExCategory.ReactStatus GetReactStatus(string reactName)
		{
			return CriAtomExCategory.ReactStatus.Stop;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000215")]
		[Address(RVA = "0x36C6E80", Offset = "0x36C5A80", VA = "0x1836C6E80")]
		public static void Stop(int id)
		{
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000216")]
		[Address(RVA = "0x36C6DF0", Offset = "0x36C59F0", VA = "0x1836C6DF0")]
		public static void Stop(string name)
		{
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000217")]
		[Address(RVA = "0x36C6CE0", Offset = "0x36C58E0", VA = "0x1836C6CE0")]
		public static void StopWithoutReleaseTime(int id)
		{
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x36C6D60", Offset = "0x36C5960", VA = "0x1836C6D60")]
		public static void StopWithoutReleaseTime(string name)
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x36C5CA0", Offset = "0x36C48A0", VA = "0x1836C5CA0")]
		public static float GetTotalVolume(int id)
		{
			return 0f;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x600021A")]
		[Address(RVA = "0x36C5D20", Offset = "0x36C4920", VA = "0x1836C5D20")]
		public static float GetTotalVolume(string name)
		{
			return 0f;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021B")]
		[Address(RVA = "0x36C67C0", Offset = "0x36C53C0", VA = "0x1836C67C0")]
		public static void SetFadeInTime(int id, ushort ms)
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021C")]
		[Address(RVA = "0x36C6720", Offset = "0x36C5320", VA = "0x1836C6720")]
		public static void SetFadeInTime(string name, ushort ms)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021D")]
		[Address(RVA = "0x36C68F0", Offset = "0x36C54F0", VA = "0x1836C68F0")]
		public static void SetFadeOutTime(int id, ushort ms)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600021E")]
		[Address(RVA = "0x36C6850", Offset = "0x36C5450", VA = "0x1836C6850")]
		public static void SetFadeOutTime(string name, ushort ms)
		{
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x600021F")]
		[Address(RVA = "0x36C64A0", Offset = "0x36C50A0", VA = "0x1836C64A0")]
		public static bool ResetAllAisacControl(int id)
		{
			return default(bool);
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x6000220")]
		[Address(RVA = "0x36C6520", Offset = "0x36C5120", VA = "0x1836C6520")]
		public static bool ResetAllAisacControl(string name)
		{
			return default(bool);
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000221")]
		[Address(RVA = "0x36C4FC0", Offset = "0x36C3BC0", VA = "0x1836C4FC0")]
		public static void AttachAisac(int id, string globalAisacName)
		{
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x36C5060", Offset = "0x36C3C60", VA = "0x1836C5060")]
		public static void AttachAisac(string name, string globalAisacName)
		{
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x36C52D0", Offset = "0x36C3ED0", VA = "0x1836C52D0")]
		public static void DetachAisac(int id, string globalAisacName)
		{
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000224")]
		[Address(RVA = "0x36C5220", Offset = "0x36C3E20", VA = "0x1836C5220")]
		public static void DetachAisac(string name, string globalAisacName)
		{
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000225")]
		[Address(RVA = "0x36C51A0", Offset = "0x36C3DA0", VA = "0x1836C51A0")]
		public static void DetachAisacAll(int id)
		{
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000226")]
		[Address(RVA = "0x36C5110", Offset = "0x36C3D10", VA = "0x1836C5110")]
		public static void DetachAisacAll(string name)
		{
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x6000227")]
		[Address(RVA = "0x36C58A0", Offset = "0x36C44A0", VA = "0x1836C58A0")]
		public static int GetNumAttachedAisacs(int id)
		{
			return 0;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x36C5920", Offset = "0x36C4520", VA = "0x1836C5920")]
		public static int GetNumAttachedAisacs(string name)
		{
			return 0;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x36C5A60", Offset = "0x36C4660", VA = "0x1836C5A60")]
		public static int GetNumCuePlayingCount(int id)
		{
			return 0;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x36C59C0", Offset = "0x36C45C0", VA = "0x1836C59C0")]
		public static int GetNumCuePlayingCount(string name)
		{
			return 0;
		}

		// Token: 0x0600022B RID: 555
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x36C6AF0", Offset = "0x36C56F0", VA = "0x1836C6AF0")]
		[PreserveSig]
		private static extern void criAtomExCategory_SetVolumeByName(string name, float volume);

		// Token: 0x0600022C RID: 556
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x36C5DC0", Offset = "0x36C49C0", VA = "0x1836C5DC0")]
		[PreserveSig]
		private static extern float criAtomExCategory_GetVolumeByName(string name);

		// Token: 0x0600022D RID: 557
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x36C6A60", Offset = "0x36C5660", VA = "0x1836C6A60")]
		[PreserveSig]
		private static extern void criAtomExCategory_SetVolumeById(int id, float volume);

		// Token: 0x0600022E RID: 558
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x36C5E60", Offset = "0x36C4A60", VA = "0x1836C5E60")]
		[PreserveSig]
		private static extern float criAtomExCategory_GetVolumeById(int id);

		// Token: 0x0600022F RID: 559
		[Token(Token = "0x600022F")]
		[Address(RVA = "0x36C62E0", Offset = "0x36C4EE0", VA = "0x1836C62E0")]
		[PreserveSig]
		private static extern void criAtomExCategory_MuteById(int id, bool mute);

		// Token: 0x06000230 RID: 560
		[Token(Token = "0x6000230")]
		[Address(RVA = "0x36C5EE0", Offset = "0x36C4AE0", VA = "0x1836C5EE0")]
		[PreserveSig]
		private static extern bool criAtomExCategory_IsMutedById(int id);

		// Token: 0x06000231 RID: 561
		[Token(Token = "0x6000231")]
		[Address(RVA = "0x36C6240", Offset = "0x36C4E40", VA = "0x1836C6240")]
		[PreserveSig]
		private static extern void criAtomExCategory_MuteByName(string name, bool mute);

		// Token: 0x06000232 RID: 562
		[Token(Token = "0x6000232")]
		[Address(RVA = "0x36C5F60", Offset = "0x36C4B60", VA = "0x1836C5F60")]
		[PreserveSig]
		private static extern bool criAtomExCategory_IsMutedByName(string name);

		// Token: 0x06000233 RID: 563
		[Token(Token = "0x6000233")]
		[Address(RVA = "0x36C6B90", Offset = "0x36C5790", VA = "0x1836C6B90")]
		[PreserveSig]
		private static extern void criAtomExCategory_SoloById(int id, bool solo, float volume);

		// Token: 0x06000234 RID: 564
		[Token(Token = "0x6000234")]
		[Address(RVA = "0x36C6120", Offset = "0x36C4D20", VA = "0x1836C6120")]
		[PreserveSig]
		private static extern bool criAtomExCategory_IsSoloedById(int id);

		// Token: 0x06000235 RID: 565
		[Token(Token = "0x6000235")]
		[Address(RVA = "0x36C6C30", Offset = "0x36C5830", VA = "0x1836C6C30")]
		[PreserveSig]
		private static extern void criAtomExCategory_SoloByName(string name, bool solo, float volume);

		// Token: 0x06000236 RID: 566
		[Token(Token = "0x6000236")]
		[Address(RVA = "0x36C61A0", Offset = "0x36C4DA0", VA = "0x1836C61A0")]
		[PreserveSig]
		private static extern bool criAtomExCategory_IsSoloedByName(string name);

		// Token: 0x06000237 RID: 567
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x36C6410", Offset = "0x36C5010", VA = "0x1836C6410")]
		[PreserveSig]
		private static extern void criAtomExCategory_PauseById(int id, bool pause);

		// Token: 0x06000238 RID: 568
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x36C60A0", Offset = "0x36C4CA0", VA = "0x1836C60A0")]
		[PreserveSig]
		private static extern bool criAtomExCategory_IsPausedById(int id);

		// Token: 0x06000239 RID: 569
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x36C6370", Offset = "0x36C4F70", VA = "0x1836C6370")]
		[PreserveSig]
		private static extern void criAtomExCategory_PauseByName(string name, bool pause);

		// Token: 0x0600023A RID: 570
		[Token(Token = "0x600023A")]
		[Address(RVA = "0x36C6000", Offset = "0x36C4C00", VA = "0x1836C6000")]
		[PreserveSig]
		private static extern bool criAtomExCategory_IsPausedByName(string name);

		// Token: 0x0600023B RID: 571
		[Token(Token = "0x600023B")]
		[Address(RVA = "0x36C7050", Offset = "0x36C5C50", VA = "0x1836C7050")]
		[PreserveSig]
		private static extern void criAtomExCategory_SetAisacControlById(int id, ushort controlId, float value);

		// Token: 0x0600023C RID: 572
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x36C6660", Offset = "0x36C5260", VA = "0x1836C6660")]
		[PreserveSig]
		private static extern void criAtomExCategory_SetAisacControlByName(string name, string controlName, float value);

		// Token: 0x0600023D RID: 573
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x36C70F0", Offset = "0x36C5CF0", VA = "0x1836C70F0")]
		[PreserveSig]
		private static extern void criAtomExCategory_SetReactParameter(string react_name, ref CriAtomExCategory.ReactParameter parameter);

		// Token: 0x0600023E RID: 574
		[Token(Token = "0x600023E")]
		[Address(RVA = "0x36C5AE0", Offset = "0x36C46E0", VA = "0x1836C5AE0")]
		[PreserveSig]
		private static extern bool criAtomExCategory_GetReactParameter(string react_name, out CriAtomExCategory.ReactParameter parameter);

		// Token: 0x0600023F RID: 575
		[Token(Token = "0x600023F")]
		[Address(RVA = "0x36C6F00", Offset = "0x36C5B00", VA = "0x1836C6F00")]
		[PreserveSig]
		private static extern bool criAtomExCategory_GetAttachedAisacInfoById(uint id, int aisacAttachedIndex, IntPtr aisacInfo);

		// Token: 0x06000240 RID: 576
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x36C6FA0", Offset = "0x36C5BA0", VA = "0x1836C6FA0")]
		[PreserveSig]
		private static extern bool criAtomExCategory_GetAttachedAisacInfoByName(string name, int aisacAttachedIndex, IntPtr aisacInfo);

		// Token: 0x06000241 RID: 577
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x36C57D0", Offset = "0x36C43D0", VA = "0x1836C57D0")]
		[PreserveSig]
		private static extern bool criAtomExCategory_GetCurrentAisacControlValueByName(string category_name, string aisac_control_name, out float control_value);

		// Token: 0x06000242 RID: 578
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x36C5C00", Offset = "0x36C4800", VA = "0x1836C5C00")]
		[PreserveSig]
		private static extern CriAtomExCategory.ReactStatus criAtomExCategory_GetReactStatus(string react_name);

		// Token: 0x06000243 RID: 579
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x36C5CA0", Offset = "0x36C48A0", VA = "0x1836C5CA0")]
		[PreserveSig]
		private static extern float criAtomExCategory_GetTotalVolumeById(int id);

		// Token: 0x06000244 RID: 580
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x36C5D20", Offset = "0x36C4920", VA = "0x1836C5D20")]
		[PreserveSig]
		private static extern float criAtomExCategory_GetTotalVolumeByName(string name);

		// Token: 0x06000245 RID: 581
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x36C67C0", Offset = "0x36C53C0", VA = "0x1836C67C0")]
		[PreserveSig]
		private static extern void criAtomExCategory_SetFadeInTimeById(int id, ushort ms);

		// Token: 0x06000246 RID: 582
		[Token(Token = "0x6000246")]
		[Address(RVA = "0x36C6720", Offset = "0x36C5320", VA = "0x1836C6720")]
		[PreserveSig]
		private static extern void criAtomExCategory_SetFadeInTimeByName(string name, ushort ms);

		// Token: 0x06000247 RID: 583
		[Token(Token = "0x6000247")]
		[Address(RVA = "0x36C68F0", Offset = "0x36C54F0", VA = "0x1836C68F0")]
		[PreserveSig]
		private static extern void criAtomExCategory_SetFadeOutTimeById(int id, ushort ms);

		// Token: 0x06000248 RID: 584
		[Token(Token = "0x6000248")]
		[Address(RVA = "0x36C6850", Offset = "0x36C5450", VA = "0x1836C6850")]
		[PreserveSig]
		private static extern void criAtomExCategory_SetFadeOutTimeByName(string name, ushort ms);

		// Token: 0x06000249 RID: 585
		[Token(Token = "0x6000249")]
		[Address(RVA = "0x36C64A0", Offset = "0x36C50A0", VA = "0x1836C64A0")]
		[PreserveSig]
		private static extern bool criAtomExCategory_ResetAllAisacControlById(int category_id);

		// Token: 0x0600024A RID: 586
		[Token(Token = "0x600024A")]
		[Address(RVA = "0x36C6520", Offset = "0x36C5120", VA = "0x1836C6520")]
		[PreserveSig]
		private static extern bool criAtomExCategory_ResetAllAisacControlByName(string category_name);

		// Token: 0x0600024B RID: 587
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x36C4FC0", Offset = "0x36C3BC0", VA = "0x1836C4FC0")]
		[PreserveSig]
		private static extern void criAtomExCategory_AttachAisacById(int id, string global_aisac_name);

		// Token: 0x0600024C RID: 588
		[Token(Token = "0x600024C")]
		[Address(RVA = "0x36C5060", Offset = "0x36C3C60", VA = "0x1836C5060")]
		[PreserveSig]
		private static extern void criAtomExCategory_AttachAisacByName(string name, string global_aisac_name);

		// Token: 0x0600024D RID: 589
		[Token(Token = "0x600024D")]
		[Address(RVA = "0x36C52D0", Offset = "0x36C3ED0", VA = "0x1836C52D0")]
		[PreserveSig]
		private static extern void criAtomExCategory_DetachAisacById(int id, string global_aisac_name);

		// Token: 0x0600024E RID: 590
		[Token(Token = "0x600024E")]
		[Address(RVA = "0x36C5220", Offset = "0x36C3E20", VA = "0x1836C5220")]
		[PreserveSig]
		private static extern void criAtomExCategory_DetachAisacByName(string name, string global_aisac_name);

		// Token: 0x0600024F RID: 591
		[Token(Token = "0x600024F")]
		[Address(RVA = "0x36C51A0", Offset = "0x36C3DA0", VA = "0x1836C51A0")]
		[PreserveSig]
		private static extern void criAtomExCategory_DetachAisacAllById(int id);

		// Token: 0x06000250 RID: 592
		[Token(Token = "0x6000250")]
		[Address(RVA = "0x36C5110", Offset = "0x36C3D10", VA = "0x1836C5110")]
		[PreserveSig]
		private static extern void criAtomExCategory_DetachAisacAllByName(string name);

		// Token: 0x06000251 RID: 593
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x36C58A0", Offset = "0x36C44A0", VA = "0x1836C58A0")]
		[PreserveSig]
		private static extern int criAtomExCategory_GetNumAttachedAisacsById(int id);

		// Token: 0x06000252 RID: 594
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x36C5920", Offset = "0x36C4520", VA = "0x1836C5920")]
		[PreserveSig]
		private static extern int criAtomExCategory_GetNumAttachedAisacsByName(string name);

		// Token: 0x06000253 RID: 595
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x36C5A60", Offset = "0x36C4660", VA = "0x1836C5A60")]
		[PreserveSig]
		private static extern int criAtomExCategory_GetNumCuePlayingCountById(int id);

		// Token: 0x06000254 RID: 596
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x36C59C0", Offset = "0x36C45C0", VA = "0x1836C59C0")]
		[PreserveSig]
		private static extern int criAtomExCategory_GetNumCuePlayingCountByName(string name);

		// Token: 0x06000255 RID: 597
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x36C6E80", Offset = "0x36C5A80", VA = "0x1836C6E80")]
		[PreserveSig]
		private static extern void criAtomExCategory_StopById(int id);

		// Token: 0x06000256 RID: 598
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x36C6DF0", Offset = "0x36C59F0", VA = "0x1836C6DF0")]
		[PreserveSig]
		private static extern void criAtomExCategory_StopByName(string name);

		// Token: 0x06000257 RID: 599
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x36C6CE0", Offset = "0x36C58E0", VA = "0x1836C6CE0")]
		[PreserveSig]
		private static extern void criAtomExCategory_StopWithoutReleaseTimeById(int id);

		// Token: 0x06000258 RID: 600
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x36C6D60", Offset = "0x36C5960", VA = "0x1836C6D60")]
		[PreserveSig]
		private static extern void criAtomExCategory_StopWithoutReleaseTimeByName(string name);

		// Token: 0x02000043 RID: 67
		[Token(Token = "0x2000043")]
		public enum ReactType
		{
			// Token: 0x040001A3 RID: 419
			[Token(Token = "0x40001A3")]
			Ducker,
			// Token: 0x040001A4 RID: 420
			[Token(Token = "0x40001A4")]
			AisacModulationTrigger
		}

		// Token: 0x02000044 RID: 68
		[Token(Token = "0x2000044")]
		public enum ReactDuckerTargetType
		{
			// Token: 0x040001A6 RID: 422
			[Token(Token = "0x40001A6")]
			Volume,
			// Token: 0x040001A7 RID: 423
			[Token(Token = "0x40001A7")]
			AisacControlValue
		}

		// Token: 0x02000045 RID: 69
		[Token(Token = "0x2000045")]
		[Obsolete("Use CriWare.CriAtomEx.CurveType instead")]
		public enum ReactDuckerCurveType
		{
			// Token: 0x040001A9 RID: 425
			[Token(Token = "0x40001A9")]
			Linear,
			// Token: 0x040001AA RID: 426
			[Token(Token = "0x40001AA")]
			Square,
			// Token: 0x040001AB RID: 427
			[Token(Token = "0x40001AB")]
			SquareReverse,
			// Token: 0x040001AC RID: 428
			[Token(Token = "0x40001AC")]
			SCurve,
			// Token: 0x040001AD RID: 429
			[Token(Token = "0x40001AD")]
			FlatAtHalf
		}

		// Token: 0x02000046 RID: 70
		[Token(Token = "0x2000046")]
		public struct ReactFadeParameter
		{
			// Token: 0x040001AE RID: 430
			[Token(Token = "0x40001AE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomEx.CurveType curveType;

			// Token: 0x040001AF RID: 431
			[Token(Token = "0x40001AF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public float curveStrength;

			// Token: 0x040001B0 RID: 432
			[Token(Token = "0x40001B0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public ushort fadeTimeMs;
		}

		// Token: 0x02000047 RID: 71
		[Token(Token = "0x2000047")]
		public enum ReactHoldType
		{
			// Token: 0x040001B2 RID: 434
			[Token(Token = "0x40001B2")]
			WhilePlaying,
			// Token: 0x040001B3 RID: 435
			[Token(Token = "0x40001B3")]
			FixedTime
		}

		// Token: 0x02000048 RID: 72
		[Token(Token = "0x2000048")]
		[StructLayout(2)]
		public struct ReactDuckerParameter
		{
			// Token: 0x040001B4 RID: 436
			[Token(Token = "0x40001B4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomExCategory.ReactDuckerParameter.Target target;

			// Token: 0x040001B5 RID: 437
			[Token(Token = "0x40001B5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public CriAtomExCategory.ReactDuckerTargetType targetType;

			// Token: 0x040001B6 RID: 438
			[Token(Token = "0x40001B6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public CriAtomExCategory.ReactFadeParameter entry;

			// Token: 0x040001B7 RID: 439
			[Token(Token = "0x40001B7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public CriAtomExCategory.ReactFadeParameter exit;

			// Token: 0x040001B8 RID: 440
			[Token(Token = "0x40001B8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public CriAtomExCategory.ReactHoldType holdType;

			// Token: 0x040001B9 RID: 441
			[Token(Token = "0x40001B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public ushort holdTimeMs;

			// Token: 0x02000049 RID: 73
			[Token(Token = "0x2000049")]
			public struct Volume
			{
				// Token: 0x040001BA RID: 442
				[Token(Token = "0x40001BA")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public float level;
			}

			// Token: 0x0200004A RID: 74
			[Token(Token = "0x200004A")]
			public struct AisacControl
			{
				// Token: 0x040001BB RID: 443
				[Token(Token = "0x40001BB")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint id;

				// Token: 0x040001BC RID: 444
				[Token(Token = "0x40001BC")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
				public float value;
			}

			// Token: 0x0200004B RID: 75
			[Token(Token = "0x200004B")]
			[StructLayout(2)]
			public struct Target
			{
				// Token: 0x040001BD RID: 445
				[Token(Token = "0x40001BD")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public CriAtomExCategory.ReactDuckerParameter.Volume volume;

				// Token: 0x040001BE RID: 446
				[Token(Token = "0x40001BE")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public CriAtomExCategory.ReactDuckerParameter.AisacControl aisacControl;
			}
		}

		// Token: 0x0200004C RID: 76
		[Token(Token = "0x200004C")]
		public struct ReactAisacModulationParameter
		{
			// Token: 0x17000041 RID: 65
			// (get) Token: 0x06000259 RID: 601 RVA: 0x00002B04 File Offset: 0x00000D04
			[Token(Token = "0x17000041")]
			public bool enableDecrementAisacModulationKey
			{
				[Token(Token = "0x6000259")]
				[Address(RVA = "0x36DC0C0", Offset = "0x36DACC0", VA = "0x1836DC0C0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x0600025A RID: 602 RVA: 0x00002B1C File Offset: 0x00000D1C
			[Token(Token = "0x17000042")]
			public bool enableIncrementAisacModulationKey
			{
				[Token(Token = "0x600025A")]
				[Address(RVA = "0x36DC0D0", Offset = "0x36DACD0", VA = "0x1836DC0D0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x040001BF RID: 447
			[Token(Token = "0x40001BF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private int _enableDecrementAisacModulationKey;

			// Token: 0x040001C0 RID: 448
			[Token(Token = "0x40001C0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public uint decrementAisacModulationKey;

			// Token: 0x040001C1 RID: 449
			[Token(Token = "0x40001C1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private int _enableIncrementAisacModulationKey;

			// Token: 0x040001C2 RID: 450
			[Token(Token = "0x40001C2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public uint incrementAisacModulationKey;
		}

		// Token: 0x0200004D RID: 77
		[Token(Token = "0x200004D")]
		[StructLayout(2)]
		public struct ReactParameter
		{
			// Token: 0x040001C3 RID: 451
			[Token(Token = "0x40001C3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public CriAtomExCategory.ReactParameter.Parameter parameter;

			// Token: 0x040001C4 RID: 452
			[Token(Token = "0x40001C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
			public CriAtomExCategory.ReactType type;

			// Token: 0x040001C5 RID: 453
			[Token(Token = "0x40001C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool enablePausingCue;

			// Token: 0x0200004E RID: 78
			[Token(Token = "0x200004E")]
			[StructLayout(2)]
			public struct Parameter
			{
				// Token: 0x040001C6 RID: 454
				[Token(Token = "0x40001C6")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public CriAtomExCategory.ReactDuckerParameter ducker;

				// Token: 0x040001C7 RID: 455
				[Token(Token = "0x40001C7")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public CriAtomExCategory.ReactAisacModulationParameter aisacModulation;
			}
		}

		// Token: 0x0200004F RID: 79
		[Token(Token = "0x200004F")]
		public enum ReactStatus
		{
			// Token: 0x040001C9 RID: 457
			[Token(Token = "0x40001C9")]
			Stop,
			// Token: 0x040001CA RID: 458
			[Token(Token = "0x40001CA")]
			FadeOut,
			// Token: 0x040001CB RID: 459
			[Token(Token = "0x40001CB")]
			Hold,
			// Token: 0x040001CC RID: 460
			[Token(Token = "0x40001CC")]
			FadeIn,
			// Token: 0x040001CD RID: 461
			[Token(Token = "0x40001CD")]
			Error
		}
	}
}
