using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	public static class SteamInput
	{
		// Token: 0x06000251 RID: 593 RVA: 0x00004D0C File Offset: 0x00002F0C
		[Token(Token = "0x6000251")]
		[Address(RVA = "0x4EC4A30", Offset = "0x4EC3630", VA = "0x184EC4A30")]
		public static bool Init(bool bExplicitlyCallRunFrame)
		{
			return default(bool);
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00004D24 File Offset: 0x00002F24
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x4EC4E90", Offset = "0x4EC3A90", VA = "0x184EC4E90")]
		public static bool Shutdown()
		{
			return default(bool);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00004D3C File Offset: 0x00002F3C
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x4EC4C70", Offset = "0x4EC3870", VA = "0x184EC4C70")]
		public static bool SetInputActionManifestFilePath(string pchInputActionManifestAbsolutePath)
		{
			return default(bool);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x4EC4BB0", Offset = "0x4EC37B0", VA = "0x184EC4BB0")]
		public static void RunFrame(bool bReservedValue = true)
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00004D54 File Offset: 0x00002F54
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x4EC39C0", Offset = "0x4EC25C0", VA = "0x184EC39C0")]
		public static bool BWaitForData(bool bWaitForever, uint unTimeout)
		{
			return default(bool);
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00004D6C File Offset: 0x00002F6C
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x4EC3970", Offset = "0x4EC2570", VA = "0x184EC3970")]
		public static bool BNewDataAvailable()
		{
			return default(bool);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00004D84 File Offset: 0x00002F84
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x4EC40A0", Offset = "0x4EC2CA0", VA = "0x184EC40A0")]
		public static int GetConnectedControllers(InputHandle_t[] handlesOut)
		{
			return 0;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x4EC3B40", Offset = "0x4EC2740", VA = "0x184EC3B40")]
		public static void EnableDeviceCallbacks()
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x4EC3AE0", Offset = "0x4EC26E0", VA = "0x184EC3AE0")]
		public static void EnableActionEventCallbacks(SteamInputActionEventCallbackPointer pCallback)
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00004D9C File Offset: 0x00002F9C
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x4EC3BF0", Offset = "0x4EC27F0", VA = "0x184EC3BF0")]
		public static InputActionSetHandle_t GetActionSetHandle(string pszActionSetName)
		{
			return default(InputActionSetHandle_t);
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x4EC3910", Offset = "0x4EC2510", VA = "0x184EC3910")]
		public static void ActivateActionSet(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00004DB4 File Offset: 0x00002FB4
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x4EC41B0", Offset = "0x4EC2DB0", VA = "0x184EC41B0")]
		public static InputActionSetHandle_t GetCurrentActionSet(InputHandle_t inputHandle)
		{
			return default(InputActionSetHandle_t);
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600025D")]
		[Address(RVA = "0x4EC38B0", Offset = "0x4EC24B0", VA = "0x184EC38B0")]
		public static void ActivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600025E")]
		[Address(RVA = "0x4EC3A20", Offset = "0x4EC2620", VA = "0x184EC3A20")]
		public static void DeactivateActionSetLayer(InputHandle_t inputHandle, InputActionSetHandle_t actionSetLayerHandle)
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x4EC3A80", Offset = "0x4EC2680", VA = "0x184EC3A80")]
		public static void DeactivateAllActionSetLayers(InputHandle_t inputHandle)
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00004DCC File Offset: 0x00002FCC
		[Token(Token = "0x6000260")]
		[Address(RVA = "0x4EC3D20", Offset = "0x4EC2920", VA = "0x184EC3D20")]
		public static int GetActiveActionSetLayers(InputHandle_t inputHandle, InputActionSetHandle_t[] handlesOut)
		{
			return 0;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00004DE4 File Offset: 0x00002FE4
		[Token(Token = "0x6000261")]
		[Address(RVA = "0x4EC42F0", Offset = "0x4EC2EF0", VA = "0x184EC42F0")]
		public static InputDigitalActionHandle_t GetDigitalActionHandle(string pszActionName)
		{
			return default(InputDigitalActionHandle_t);
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00004DFC File Offset: 0x00002FFC
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x4EC4290", Offset = "0x4EC2E90", VA = "0x184EC4290")]
		public static InputDigitalActionData_t GetDigitalActionData(InputHandle_t inputHandle, InputDigitalActionHandle_t digitalActionHandle)
		{
			return default(InputDigitalActionData_t);
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00004E14 File Offset: 0x00003014
		[Token(Token = "0x6000263")]
		[Address(RVA = "0x4EC4420", Offset = "0x4EC3020", VA = "0x184EC4420")]
		public static int GetDigitalActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputDigitalActionHandle_t digitalActionHandle, EInputActionOrigin[] originsOut)
		{
			return 0;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x4EC4970", Offset = "0x4EC3570", VA = "0x184EC4970")]
		public static string GetStringForDigitalActionName(InputDigitalActionHandle_t eActionHandle)
		{
			return null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00004E2C File Offset: 0x0000302C
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x4EC3E80", Offset = "0x4EC2A80", VA = "0x184EC3E80")]
		public static InputAnalogActionHandle_t GetAnalogActionHandle(string pszActionName)
		{
			return default(InputAnalogActionHandle_t);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00004E44 File Offset: 0x00003044
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x4EC3DE0", Offset = "0x4EC29E0", VA = "0x184EC3DE0")]
		public static InputAnalogActionData_t GetAnalogActionData(InputHandle_t inputHandle, InputAnalogActionHandle_t analogActionHandle)
		{
			return default(InputAnalogActionData_t);
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00004E5C File Offset: 0x0000305C
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x4EC3FB0", Offset = "0x4EC2BB0", VA = "0x184EC3FB0")]
		public static int GetAnalogActionOrigins(InputHandle_t inputHandle, InputActionSetHandle_t actionSetHandle, InputAnalogActionHandle_t analogActionHandle, EInputActionOrigin[] originsOut)
		{
			return 0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x4EC4630", Offset = "0x4EC3230", VA = "0x184EC4630")]
		public static string GetGlyphPNGForActionOrigin(EInputActionOrigin eOrigin, ESteamInputGlyphSize eSize, uint unFlags)
		{
			return null;
		}

		// Token: 0x06000269 RID: 617 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x4EC46B0", Offset = "0x4EC32B0", VA = "0x184EC46B0")]
		public static string GetGlyphSVGForActionOrigin(EInputActionOrigin eOrigin, uint unFlags)
		{
			return null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x4EC4570", Offset = "0x4EC3170", VA = "0x184EC4570")]
		public static string GetGlyphForActionOrigin_Legacy(EInputActionOrigin eOrigin)
		{
			return null;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600026B")]
		[Address(RVA = "0x4EC48B0", Offset = "0x4EC34B0", VA = "0x184EC48B0")]
		public static string GetStringForActionOrigin(EInputActionOrigin eOrigin)
		{
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600026C")]
		[Address(RVA = "0x4EC4910", Offset = "0x4EC3510", VA = "0x184EC4910")]
		public static string GetStringForAnalogActionName(InputAnalogActionHandle_t eActionHandle)
		{
			return null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x4EC4EE0", Offset = "0x4EC3AE0", VA = "0x184EC4EE0")]
		public static void StopAnalogActionMomentum(InputHandle_t inputHandle, InputAnalogActionHandle_t eAction)
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00004E74 File Offset: 0x00003074
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x4EC4780", Offset = "0x4EC3380", VA = "0x184EC4780")]
		public static InputMotionData_t GetMotionData(InputHandle_t inputHandle)
		{
			return default(InputMotionData_t);
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x4EC50E0", Offset = "0x4EC3CE0", VA = "0x184EC50E0")]
		public static void TriggerVibration(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x4EC5040", Offset = "0x4EC3C40", VA = "0x184EC5040")]
		public static void TriggerVibrationExtended(InputHandle_t inputHandle, ushort usLeftSpeed, ushort usRightSpeed, ushort usLeftTriggerSpeed, ushort usRightTriggerSpeed)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000271")]
		[Address(RVA = "0x4EC4FA0", Offset = "0x4EC3BA0", VA = "0x184EC4FA0")]
		public static void TriggerSimpleHapticEvent(InputHandle_t inputHandle, EControllerHapticLocation eHapticLocation, byte nIntensity, char nGainDB, byte nOtherIntensity, char nOtherGainDB)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000272")]
		[Address(RVA = "0x4EC4D90", Offset = "0x4EC3990", VA = "0x184EC4D90")]
		public static void SetLEDColor(InputHandle_t inputHandle, byte nColorR, byte nColorG, byte nColorB, uint nFlags)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000273")]
		[Address(RVA = "0x4EC4A90", Offset = "0x4EC3690", VA = "0x184EC4A90")]
		public static void Legacy_TriggerHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec)
		{
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000274")]
		[Address(RVA = "0x4EC4B10", Offset = "0x4EC3710", VA = "0x184EC4B10")]
		public static void Legacy_TriggerRepeatedHapticPulse(InputHandle_t inputHandle, ESteamControllerPad eTargetPad, ushort usDurationMicroSec, ushort usOffMicroSec, ushort unRepeat, uint nFlags)
		{
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00004E8C File Offset: 0x0000308C
		[Token(Token = "0x6000275")]
		[Address(RVA = "0x4EC4E30", Offset = "0x4EC3A30", VA = "0x184EC4E30")]
		public static bool ShowBindingPanel(InputHandle_t inputHandle)
		{
			return default(bool);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00004EA4 File Offset: 0x000030A4
		[Token(Token = "0x6000276")]
		[Address(RVA = "0x4EC4720", Offset = "0x4EC3320", VA = "0x184EC4720")]
		public static ESteamInputType GetInputTypeForHandle(InputHandle_t inputHandle)
		{
			return ESteamInputType.k_ESteamInputType_Unknown;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00004EBC File Offset: 0x000030BC
		[Token(Token = "0x6000277")]
		[Address(RVA = "0x4EC4150", Offset = "0x4EC2D50", VA = "0x184EC4150")]
		public static InputHandle_t GetControllerForGamepadIndex(int nIndex)
		{
			return default(InputHandle_t);
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00004ED4 File Offset: 0x000030D4
		[Token(Token = "0x6000278")]
		[Address(RVA = "0x4EC4510", Offset = "0x4EC3110", VA = "0x184EC4510")]
		public static int GetGamepadIndexForController(InputHandle_t ulinputHandle)
		{
			return 0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x6000279")]
		[Address(RVA = "0x4EC49D0", Offset = "0x4EC35D0", VA = "0x184EC49D0")]
		public static string GetStringForXboxOrigin(EXboxOrigin eOrigin)
		{
			return null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x000020AE File Offset: 0x000002AE
		[Token(Token = "0x600027A")]
		[Address(RVA = "0x4EC45D0", Offset = "0x4EC31D0", VA = "0x184EC45D0")]
		public static string GetGlyphForXboxOrigin(EXboxOrigin eOrigin)
		{
			return null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00004EEC File Offset: 0x000030EC
		[Token(Token = "0x600027B")]
		[Address(RVA = "0x4EC3B90", Offset = "0x4EC2790", VA = "0x184EC3B90")]
		public static EInputActionOrigin GetActionOriginFromXboxOrigin(InputHandle_t inputHandle, EXboxOrigin eOrigin)
		{
			return EInputActionOrigin.k_EInputActionOrigin_None;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00004F04 File Offset: 0x00003104
		[Token(Token = "0x600027C")]
		[Address(RVA = "0x4EC4F40", Offset = "0x4EC3B40", VA = "0x184EC4F40")]
		public static EInputActionOrigin TranslateActionOrigin(ESteamInputType eDestinationInputType, EInputActionOrigin eSourceOrigin)
		{
			return EInputActionOrigin.k_EInputActionOrigin_None;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00004F1C File Offset: 0x0000311C
		[Token(Token = "0x600027D")]
		[Address(RVA = "0x4EC4210", Offset = "0x4EC2E10", VA = "0x184EC4210")]
		public static bool GetDeviceBindingRevision(InputHandle_t inputHandle, out int pMajor, out int pMinor)
		{
			return default(bool);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00004F34 File Offset: 0x00003134
		[Token(Token = "0x600027E")]
		[Address(RVA = "0x4EC4800", Offset = "0x4EC3400", VA = "0x184EC4800")]
		public static uint GetRemotePlaySessionID(InputHandle_t inputHandle)
		{
			return 0U;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00004F4C File Offset: 0x0000314C
		[Token(Token = "0x600027F")]
		[Address(RVA = "0x4EC4860", Offset = "0x4EC3460", VA = "0x184EC4860")]
		public static ushort GetSessionInputConfigurationSettings()
		{
			return 0;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00002142 File Offset: 0x00000342
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x4EC4C10", Offset = "0x4EC3810", VA = "0x184EC4C10")]
		public static void SetDualSenseTriggerEffect(InputHandle_t inputHandle, IntPtr pParam)
		{
		}
	}
}
