﻿using UnityEngine;
using System.Collections;

namespace Tiles {
    public class Warehouse : Tile {
        public Warehouse() {
            this.filled = false;
        }

        public override void Create(int x, int y, Geometry geometry, Tile[] sides) {
            if (sides[0] != null && sides[0].filled) {
                geometry.CreateFace(x, 1, y + 1, Geometry.Direction.south, Textures.TEXTURES["concrete_wall_2"].uv);
                geometry.CreateFace(x, 2, y + 1, Geometry.Direction.south, Textures.TEXTURES["concrete_wall_1"].uv);
            }

            if (sides[1] != null && sides[1].filled) {
                geometry.CreateFace(x + 1, 1, y, Geometry.Direction.west, Textures.TEXTURES["concrete_wall_2"].uv);
                geometry.CreateFace(x + 1, 2, y, Geometry.Direction.west, Textures.TEXTURES["concrete_wall_1"].uv);
            }

            if (sides[2] != null && sides[2].filled) {
                geometry.CreateFace(x, 1, y - 1, Geometry.Direction.north, Textures.TEXTURES["concrete_wall_2"].uv);
                geometry.CreateFace(x, 2, y - 1, Geometry.Direction.north, Textures.TEXTURES["concrete_wall_1"].uv);
            }

            if (sides[3] != null && sides[3].filled) {
                geometry.CreateFace(x - 1, 1, y, Geometry.Direction.east, Textures.TEXTURES["concrete_wall_2"].uv);
                geometry.CreateFace(x - 1, 2, y, Geometry.Direction.east, Textures.TEXTURES["concrete_wall_1"].uv);
            }

            geometry.CreateFace(x, 0, y, Geometry.Direction.up, Textures.TEXTURES["planks_0"].uv);
        }
    }
}
