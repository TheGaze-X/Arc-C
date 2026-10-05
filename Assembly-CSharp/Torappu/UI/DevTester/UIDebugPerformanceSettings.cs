using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.UI.DevTester
{
	// Token: 0x020050FF RID: 20735
	[Token(Token = "0x20050FF")]
	public class UIDebugPerformanceSettings : MonoBehaviour
	{
		// Token: 0x0601EA15 RID: 125461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601EA15")]
		[Address(RVA = "0x4EC010", Offset = "0x4EAC10", VA = "0x1804EC010")]
		public UIDebugPerformanceSettings()
		{
		}

		// Token: 0x04029114 RID: 168212
		[Token(Token = "0x4029114")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Group("Toggles")]
		private Toggle _fpsTog;

		// Token: 0x04029115 RID: 168213
		[Token(Token = "0x4029115")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Toggles")]
		private Toggle _buildingBloomTog;

		// Token: 0x04029116 RID: 168214
		[Token(Token = "0x4029116")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Toggles")]
		private Toggle _ppColorGradingTog;

		// Token: 0x04029117 RID: 168215
		[Token(Token = "0x4029117")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Toggles")]
		private Toggle _ppBloomTog;

		// Token: 0x04029118 RID: 168216
		[Token(Token = "0x4029118")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Toggles")]
		private Toggle _ppVignetteTog;

		// Token: 0x04029119 RID: 168217
		[Token(Token = "0x4029119")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Toggles")]
		private Toggle _waterEffectTog;

		// Token: 0x0402911A RID: 168218
		[Token(Token = "0x402911A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Toggles")]
		private Toggle _shadowCameraTog;

		// Token: 0x0402911B RID: 168219
		[Token(Token = "0x402911B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Dropdown _qualityLevel;

		// Token: 0x0402911C RID: 168220
		[Token(Token = "0x402911C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _benchmarkResult;
	}
}
