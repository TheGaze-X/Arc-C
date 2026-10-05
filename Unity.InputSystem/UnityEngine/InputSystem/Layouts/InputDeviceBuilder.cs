using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Il2CppDummyDll;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem.Layouts
{
	// Token: 0x02000204 RID: 516
	[Token(Token = "0x2000204")]
	internal struct InputDeviceBuilder : IDisposable
	{
		// Token: 0x06001306 RID: 4870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001306")]
		[Address(RVA = "0x5604060", Offset = "0x5602C60", VA = "0x185604060")]
		public void Setup(InternedString layout, InternedString variants, [Optional] InputDeviceDescription deviceDescription)
		{
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001307")]
		[Address(RVA = "0x5601F70", Offset = "0x5600B70", VA = "0x185601F70")]
		public InputDevice Finish()
		{
			return null;
		}

		// Token: 0x06001308 RID: 4872 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001308")]
		[Address(RVA = "0x5601700", Offset = "0x5600300", VA = "0x185601700", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001309")]
		[Address(RVA = "0x5603BC0", Offset = "0x56027C0", VA = "0x185603BC0")]
		private void Reset()
		{
		}

		// Token: 0x0600130A RID: 4874 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600130A")]
		[Address(RVA = "0x5603A80", Offset = "0x5602680", VA = "0x185603A80")]
		private InputControl InstantiateLayout(InternedString layout, InternedString variants, InternedString name, InputControl parent)
		{
			return null;
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600130B")]
		[Address(RVA = "0x5603250", Offset = "0x5601E50", VA = "0x185603250")]
		private InputControl InstantiateLayout(InputControlLayout layout, InternedString variants, InternedString name, InputControl parent)
		{
			return null;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130C")]
		[Address(RVA = "0x55FFB20", Offset = "0x55FE720", VA = "0x1855FFB20")]
		private void AddChildControls(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls)
		{
		}

		// Token: 0x0600130D RID: 4877 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600130D")]
		[Address(RVA = "0x55FEED0", Offset = "0x55FDAD0", VA = "0x1855FEED0")]
		private InputControl AddChildControl(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, InputControlLayout.ControlItem controlItem, int childIndex, [Optional] string nameOverride)
		{
			return null;
		}

		// Token: 0x0600130E RID: 4878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600130E")]
		[Address(RVA = "0x56025E0", Offset = "0x56011E0", VA = "0x1856025E0")]
		private void InsertChildControlOverride(InputControl parent, ref InputControlLayout.ControlItem controlItem)
		{
		}

		// Token: 0x0600130F RID: 4879 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600130F")]
		[Address(RVA = "0x5600D40", Offset = "0x55FF940", VA = "0x185600D40")]
		private string ChildControlOverridePath(InputControl parent, InternedString controlName)
		{
			return null;
		}

		// Token: 0x06001310 RID: 4880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001310")]
		[Address(RVA = "0x55FEDE0", Offset = "0x55FD9E0", VA = "0x1855FEDE0")]
		private void AddChildControlIfMissing(InputControlLayout layout, InternedString variants, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem)
		{
		}

		// Token: 0x06001311 RID: 4881 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001311")]
		[Address(RVA = "0x56029C0", Offset = "0x56015C0", VA = "0x1856029C0")]
		private InputControl InsertChildControl(InputControlLayout layout, InternedString variant, InputControl parent, ref bool haveChildrenUsingStateFromOtherControls, ref InputControlLayout.ControlItem controlItem)
		{
			return null;
		}

		// Token: 0x06001312 RID: 4882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001312")]
		[Address(RVA = "0x5600B00", Offset = "0x55FF700", VA = "0x185600B00")]
		private static void ApplyUseStateFrom(InputControl parent, ref InputControlLayout.ControlItem controlItem, InputControlLayout layout)
		{
		}

		// Token: 0x06001313 RID: 4883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001313")]
		[Address(RVA = "0x5604250", Offset = "0x5602E50", VA = "0x185604250")]
		private static void ShiftChildIndicesInHierarchyOneUp(InputDevice device, int startIndex, InputControl exceptControl)
		{
		}

		// Token: 0x06001314 RID: 4884 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001314")]
		[Address(RVA = "0x5603C30", Offset = "0x5602830", VA = "0x185603C30")]
		private void SetDisplayName(InputControl control, string longDisplayNameFromLayout, string shortDisplayNameFromLayout, bool shortName)
		{
		}

		// Token: 0x06001315 RID: 4885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001315")]
		[Address(RVA = "0x5600800", Offset = "0x55FF400", VA = "0x185600800")]
		private static void AddParentDisplayNameRecursive(InputControl control, StringBuilder stringBuilder, bool shortName)
		{
		}

		// Token: 0x06001316 RID: 4886 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001316")]
		[Address(RVA = "0x56008A0", Offset = "0x55FF4A0", VA = "0x1856008A0")]
		private static void AddProcessors(InputControl control, ref InputControlLayout.ControlItem controlItem, string layoutName)
		{
		}

		// Token: 0x06001317 RID: 4887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001317")]
		[Address(RVA = "0x5603FB0", Offset = "0x5602BB0", VA = "0x185603FB0")]
		private static void SetFormat(InputControl control, InputControlLayout.ControlItem controlItem)
		{
		}

		// Token: 0x06001318 RID: 4888 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001318")]
		[Address(RVA = "0x5601F10", Offset = "0x5600B10", VA = "0x185601F10")]
		private static InputControlLayout FindOrLoadLayout(string name)
		{
			return null;
		}

		// Token: 0x06001319 RID: 4889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001319")]
		[Address(RVA = "0x5600DC0", Offset = "0x55FF9C0", VA = "0x185600DC0")]
		private static void ComputeStateLayout(InputControl control)
		{
		}

		// Token: 0x0600131A RID: 4890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x5601C40", Offset = "0x5600840", VA = "0x185601C40")]
		private void FinalizeControlHierarchy()
		{
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131B")]
		[Address(RVA = "0x5601710", Offset = "0x5600310", VA = "0x185601710")]
		private void FinalizeControlHierarchyRecursive(InputControl control, int controlIndex, InputControl[] allControls, bool noisy, bool dontReset, ref int controlIndiciesNextFreeIndex)
		{
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x5602EA0", Offset = "0x5601AA0", VA = "0x185602EA0")]
		private void InsertControlBitRangeNode(ref InputDevice.ControlBitRangeNode parent, InputControl control, ref int controlIndiciesNextFreeIndex, ushort startOffset)
		{
		}

		// Token: 0x0600131D RID: 4893 RVA: 0x00009FA8 File Offset: 0x000081A8
		[Token(Token = "0x600131D")]
		[Address(RVA = "0x5601F90", Offset = "0x5600B90", VA = "0x185601F90")]
		private ushort GetBestMidPoint(InputDevice.ControlBitRangeNode parent, ushort startOffset)
		{
			return 0;
		}

		// Token: 0x0600131E RID: 4894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x5600690", Offset = "0x55FF290", VA = "0x185600690")]
		private void AddControlToNode(InputControl control, ref int controlIndiciesNextFreeIndex, int nodeIndex)
		{
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x5600560", Offset = "0x55FF160", VA = "0x185600560")]
		private void AddChildren(ref InputDevice.ControlBitRangeNode parent, InputDevice.ControlBitRangeNode left, InputDevice.ControlBitRangeNode right)
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00009FC0 File Offset: 0x000081C0
		[Token(Token = "0x6001320")]
		[Address(RVA = "0x5602510", Offset = "0x5601110", VA = "0x185602510")]
		private ushort GetControlIndex(InputControl control)
		{
			return 0;
		}

		// Token: 0x17000576 RID: 1398
		// (get) Token: 0x06001321 RID: 4897 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000576")]
		internal static ref InputDeviceBuilder instance
		{
			[Token(Token = "0x6001321")]
			[Address(RVA = "0x56042C0", Offset = "0x5602EC0", VA = "0x1856042C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001322 RID: 4898 RVA: 0x00009FD8 File Offset: 0x000081D8
		[Token(Token = "0x6001322")]
		[Address(RVA = "0x5603B80", Offset = "0x5602780", VA = "0x185603B80")]
		internal static InputDeviceBuilder.RefInstance Ref()
		{
			return default(InputDeviceBuilder.RefInstance);
		}

		// Token: 0x04000B54 RID: 2900
		[Token(Token = "0x4000B54")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private InputDevice m_Device;

		// Token: 0x04000B55 RID: 2901
		[Token(Token = "0x4000B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private InputControlLayout.CacheRefInstance m_LayoutCacheRef;

		// Token: 0x04000B56 RID: 2902
		[Token(Token = "0x4000B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private Dictionary<string, InputControlLayout.ControlItem> m_ChildControlOverrides;

		// Token: 0x04000B57 RID: 2903
		[Token(Token = "0x4000B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private List<uint> m_StateOffsetToControlMap;

		// Token: 0x04000B58 RID: 2904
		[Token(Token = "0x4000B58")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private StringBuilder m_StringBuilder;

		// Token: 0x04000B59 RID: 2905
		[Token(Token = "0x4000B59")]
		private const uint kSizeForControlUsingStateFromOtherControl = 4294967295U;

		// Token: 0x04000B5A RID: 2906
		[Token(Token = "0x4000B5A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static InputDeviceBuilder s_Instance;

		// Token: 0x04000B5B RID: 2907
		[Token(Token = "0x4000B5B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static int s_InstanceRef;

		// Token: 0x02000205 RID: 517
		[Token(Token = "0x2000205")]
		internal struct RefInstance : IDisposable
		{
			// Token: 0x06001323 RID: 4899 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001323")]
			[Address(RVA = "0x560C830", Offset = "0x560B430", VA = "0x18560C830", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
