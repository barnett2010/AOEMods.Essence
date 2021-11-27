﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOEMods.Essence.SGA;

public record ArchiveHeader(
    byte[] Magic,
    ushort Version, ushort Product, string NiceName, ulong Offset, ulong DataOffset,
    uint TocDataOffset, uint TocDataCount, uint FolderDataOffset, uint FolderDataCount,
    uint FileDataOffset, uint FileDataCount, uint StringOffset, uint BlockSize
);
